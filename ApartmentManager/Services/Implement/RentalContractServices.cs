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
using ViewModel.Dtos;
using ViewModel.People;
using ViewModel.RentalContract;
using ViewModel.Room;

namespace Services.Implement
{
    public class RentalContractServices : IRentalContract
    {
        private readonly ApartmentDbContextFactory _contextfactory;
        public RentalContractServices(ApartmentDbContextFactory contextfactory)
        {
            _contextfactory = contextfactory;
        }

        public Task<RentalContract> Create(RentalContractCreateViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<RentalContractVm>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResult<RentalContractVm>> GetAllPage(RequestPaging request)
        {
            using (AparmentDbContext _context = _contextfactory.CreateDbContext())
            {
                var query = from p in _context.RentalContract
                            join pt in _context.Room on p.IDroom equals pt.ID
                            join px in _context.People on p.IDLeader equals px.ID
                            select new { p, pt, px };

                int totalRow = await query.CountAsync();
                var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .Select(x => new RentalContractVm()
                    {
                        ID = x.p.ID,
                        RoomName = x.pt.Name,
                        LeaderName = x.px.Name,
                        ReceiveDate = x.p.ReceiveDate,
                        CheckOutDate = x.p.CheckOutDate,
                        RoomMoney = x.p.RoomMoney,
                        ElectricMoney = x.p.ElectricMoney,
                        WaterMoney = x.p.WaterMoney,
                        ServiceMoney = x.p.ServiceMoney
                    }).ToListAsync();
                var pagedView = new PagedResult<RentalContractVm>()
                {
                    TotalRecords = totalRow,
                    PageIndex = request.PageIndex,
                    PageSize = request.PageSize,
                    Items = data
                };
                return pagedView;
            }
        }

        public Task<RentalContract> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<RentalContract> Update(int id, RentalContractUpdateViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}