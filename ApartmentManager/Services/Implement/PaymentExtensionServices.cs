using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;
using ViewModel.Furniture;
using ViewModel.PaymentExtension;
using ViewModel.People;

namespace Services.Implement
{
    public class PaymentExtensionServices : IPaymentExtension
    {
        private readonly ApartmentDbContextFactory _contextfactory;
        public PaymentExtensionServices(ApartmentDbContextFactory contextfactory)
        {
            _contextfactory = contextfactory;
        }
        public Task<int> CreatePaymentExtension(PaymentExtensionCreateViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeletePaymentExtension(int PeID)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResult<PaymentExtensionVm>> GetAllPage(RequestPaging request)
        {
            using (AparmentDbContext _context = _contextfactory.CreateDbContext())
            {
                var query = from p in _context.PaymentExtension
                            join pt in _context.Bill on p.IDBill equals pt.ID
                            select new { p,pt};
                int totalRow = await query.CountAsync();
                var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .Select(x => new PaymentExtensionVm()
                    {
                        ID = x.p.ID,
                        IDBill = x.pt.ID,
                        Days = x.p.Days
                    }).ToListAsync();
                var pagedView = new PagedResult<PaymentExtensionVm>()
                {
                    TotalRecords = totalRow,
                    PageIndex = request.PageIndex,
                    PageSize = request.PageSize,
                    Items = data
                };
                return pagedView;
            }
        }

        public Task<int> UpdatePaymentExtension(PaymentExtensionUpdateViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}