using Data;
using Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.IdentityModel.Abstractions;
using Services.Interface;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ViewModel.Dtos;
using ViewModel.People;
using ViewModel.Room;

namespace Services.Implement
{
    public class RoomServices : IRoom
    {
        private readonly ApartmentDbContextFactory _contextfactory;
        private readonly IBaseControl<Room> _base;

        public RoomServices(ApartmentDbContextFactory contextfactory,IBaseControl<Room> baseControl)
        {
            _contextfactory=contextfactory;
            _base = baseControl;
        }

        public async Task<Room> Create(RoomCreateViewModel model)
        {
            var room = new Data.Entity.Room()
            {
                ID = model.ID,
                IDLeader = model.IDLeader,
                Name = model.Name,
                Quantity = model.Quantity,
            };
            
             return await _base.Create(room);
        }

        public async Task<bool> Delete(int id)
        {   
            await _base.Delete(id);
            return true;

        }

        public async Task<List<RoomVm>> GetAll()
        {
            
            using (AparmentDbContext _context = _contextfactory.CreateDbContext())
            {
                var query = from p in _context.Room
                            join pt in _context.People on p.IDLeader equals pt.ID
                            select new { p, pt };
                var data = await query.Select(x => new RoomVm()
                {
                    ID = x.p.ID,
                    NameLeader = x.pt.Name,
                    Name = x.p.Name,
                    Quantity = x.p.Quantity
                }).ToListAsync();
                return data;
            }
            /*List<Room> result = await _base.GetAll();
            var result1 = result.Select(e => new RoomVm
            {
                ID = e.ID,
                NameLeader = e.Name,
                Name = e.Name,
                Quantity=e.Quantity,

            }).ToList();
            return result1;*/
        }

        public PagedResult<RoomVm> GetAllPage(RequestPaging request)
        {
            using (AparmentDbContext _context = _contextfactory.CreateDbContext())
            {
                var query = from p in _context.Room
                            join pt in _context.People on p.IDLeader equals pt.ID
                            select new { p, pt };
                int totalRow = query.Count();
                var data = query.Skip((request.PageIndex - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .Select(x => new RoomVm()
                    {
                        ID = x.p.ID,
                        NameLeader = x.pt.Name,
                        Name = x.p.Name,
                        Quantity = x.p.Quantity
                    }).ToList();
                var pagedView = new PagedResult<RoomVm>()
                {
                    TotalRecords = totalRow,
                    PageIndex = request.PageIndex,
                    PageSize = request.PageSize,
                    Items = data
                };
                return pagedView;
            }
        }

        public async Task<Room> GetById(int id)
        {
            return await _base.GetById(id);
            
        }

        public async Task<Room> Update(int id, RoomUpdateViewModel model)
        {
            var room = new Data.Entity.Room();
            room.ID = model.ID;
            room.IDLeader = model.IDLeader;
            room.Name = model.Name;
            room.Quantity = model.Quantity;
            return await _base.Update(model.ID, room);
        }

        public async Task<int> UpdateRoom(RoomUpdateViewModel model)
        {
            using (AparmentDbContext _context = _contextfactory.CreateDbContext())
            {
                var room =await _context.Room.FindAsync(model.ID);
                room.ID = model.ID;
                room.IDLeader = model.IDLeader;
                room.Name = model.Name;
                room.Quantity = model.Quantity;
                _context.Room.Update(room);
                return await _context.SaveChangesAsync();
            }
            
        }

        
    }
}