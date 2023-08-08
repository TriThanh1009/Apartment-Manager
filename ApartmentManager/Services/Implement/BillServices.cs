using Data;
using Microsoft.EntityFrameworkCore.Internal;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Bill;
using ViewModel.Dtos;
using ViewModel.People;
using ViewModel.Room;

namespace Services.Implement
{
    public class BillServices : IBill
    {
        private readonly ApartmentDbContextFactory _contextfactory;
        public BillServices(ApartmentDbContextFactory contextfactory) {
            _contextfactory = contextfactory;
        }

        public Task<int> CreateBill(BillCreateViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteBill(int BillID)
        {
            throw new NotImplementedException();
        }

        public PagedResult<BillVm> GetAllPage(RequestPaging request)
        {
            using (AparmentDbContext _context = _contextfactory.CreateDbContext())
            {
                var query = from p in _context.Bill
                            join pt in _context.RentalContract on p.IDRTC equals pt.ID
                            select new { p, pt };
                int totalRow = query.Count();
                var data = query.Skip((request.PageIndex - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .Select(x => new BillVm()
                    {
                        ID = x.p.ID,
                        IDRTC = x.pt.ID,
                        ElectricQuantity = x.p.ElectricQuantity,
                        Active = x.p.Active,
                        PayDate = x.p.PayDate,
                        TotalMoney = x.p.TotalMoney
                        
                    }).ToList();
                var pagedView = new PagedResult<BillVm>()
                {
                    TotalRecords = totalRow,
                    PageIndex = request.PageIndex,
                    PageSize = request.PageSize,
                    Items = data
                };
                return pagedView;
            }
        }

        public Task<int> UpdateBill(BillUpdateViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}