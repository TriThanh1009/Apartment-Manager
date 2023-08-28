using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.DepositsContract;
using ViewModel.Dtos;
using ViewModel.People;
using ViewModel.Room;

namespace Services.Implement
{
    public class DepositsContractServices : IDepositsContract
    {
        private readonly ApartmentDbContextFactory _contextfactory;
        public DepositsContractServices(ApartmentDbContextFactory contextfactory)
        {
            _contextfactory = contextfactory;
        }
        public Task<int> CreateDepositsContract(DepositsContractCreateViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteDepositsContract(int depositsId)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResult<DepositsContractVm>> GetAllPage(RequestPaging request)
        {
            using (AparmentDbContext _context = _contextfactory.CreateDbContext())
            {
                var query = from p in _context.DepositsContract
                            join pt in _context.Room on p.IDRoom equals pt.ID
                            select new { p, pt };
                int totalRow = await query.CountAsync();
                var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .Select(x => new DepositsContractVm()
                    {
                        ID = x.p.ID,
                        RoomName = x.pt.Name,
                        DepositsDate = x.p.DepositsDate,
                        ReceiveDate = x.p.ReceiveDate,
                        CheckOutDate = x.p.CheckOutDate,
                        Money = x.p.Money
                       
                    }).ToListAsync();
                var pagedView = new PagedResult<DepositsContractVm>()
                {
                    TotalRecords = totalRow,
                    PageIndex = request.PageIndex,
                    PageSize = request.PageSize,
                    Items = data
                };
                return pagedView;
            }
        }

        public Task<int> UpdateDepositsContract(DepositsContractUpdateViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
