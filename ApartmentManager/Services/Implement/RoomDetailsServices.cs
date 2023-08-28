using Data;
using Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ViewModel.Dtos;
using ViewModel.Furniture;
using ViewModel.People;
using ViewModel.Room;
using ViewModel.RoomDetails;

namespace Services.Implement
{
    public class RoomDetailsServices : IRoomDetails
    {
        private readonly ApartmentDbContextFactory _contextfactory;
        private readonly IBaseControl<Room> _base;

        public RoomDetailsServices(ApartmentDbContextFactory contextfactory, IBaseControl<Room> baseControl)
        {
            _contextfactory = contextfactory;
            _base = baseControl;
        }

        public async Task<bool> Delete(int id)
        {
            await _base.Delete(id);
            return true;
        }

        public async Task<PagedResult<RoomDetailsFurniture>> GetAllFurniture(RequestPaging request,int id)
        {
            using (AparmentDbContext _context = _contextfactory.CreateDbContext())
            {
                var query = from p in _context.RoomDetail
                            join pt in _context.Furniture on p.IDFur equals pt.ID
                            join px in _context.Room on p.IDRoom equals px.ID
                            select new { p, pt};
                int totalRow = await query.CountAsync();
                var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .Where(x => x.p.IDRoom == id)
                    .Select(x => new RoomDetailsFurniture()
                    {
                        IdRoom = x.p.IDRoom,
                        IdFur = x.pt.ID,
                        NameFurniture = x.pt.Name,
                    }).ToListAsync();
                var pagedView = new PagedResult<RoomDetailsFurniture>()
                {
                    TotalRecords = totalRow,
                    PageIndex = request.PageIndex,
                    PageSize = request.PageSize,
                    Items = data
                };
                return pagedView;
            }
        }

        public async Task<PagedResult<RoomDetailsImage>> GetAllImage(RequestPaging request,int id)
        {
            using (AparmentDbContext _context = _contextfactory.CreateDbContext())
            {
                var query = from p in _context.RoomImage
                            where p.IDroom == id

                            select p;
                int totalRow = await query.CountAsync();
                var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .Select(x => new RoomDetailsImage()
                    {
                       IDRoom = x.IDroom,
                        IDImage = x.ID,
                        Url = x.Url
                    }).ToListAsync();
                var pagedView = new PagedResult<RoomDetailsImage>()
                {
                    TotalRecords = totalRow,
                    PageIndex = request.PageIndex,
                    PageSize = request.PageSize,
                    Items = data
                };
                return pagedView;
            }
        }


        public async Task<PagedResult<RoomDetailsVm>> GetAllRoom(RequestPaging request)
        {
            using (AparmentDbContext _context = _contextfactory.CreateDbContext())
            {
                var query = from p in _context.RoomDetail
                            join px in _context.Room on p.IDRoom equals px.ID
                            select new { p, px };
                int totalRow = await query.CountAsync();
                var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .Select(x => new RoomDetailsVm()
                    {
                        RoomName = x.px.Name
                    }).ToListAsync();
                var pagedView = new PagedResult<RoomDetailsVm>()
                {
                    TotalRecords = totalRow,
                    PageIndex = request.PageIndex,
                    PageSize = request.PageSize,
                    Items = data
                };
                return pagedView;
            }
        }

        public async Task<PagedResult<RoomDetailsVm>> GetAllPage(RequestPaging request)
        {
            using (AparmentDbContext _context = _contextfactory.CreateDbContext())
            {
                var query = from p in _context.RoomDetail
                            join pt in _context.Furniture on p.IDFur equals pt.ID
                            join px in _context.Room on p.IDRoom equals px.ID
                            select new {p,pt,px};
                int totalRow = await query.CountAsync();
                var data =await query.Skip((request.PageIndex - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .Select(x => new RoomDetailsVm()
                    {
                        FurName = x.pt.Name,
                        RoomName = x.px.Name
                    }).ToListAsync();
                var pagedView = new PagedResult<RoomDetailsVm>()
                {
                    TotalRecords = totalRow,
                    PageIndex = request.PageIndex,
                    PageSize = request.PageSize,
                    Items = data
                };
                return pagedView;
            }
        }

        
    }
}