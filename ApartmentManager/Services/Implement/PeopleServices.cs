using Data;
using Microsoft.EntityFrameworkCore;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;
using ViewModel.People;

namespace Services.Implement
{
    public class PeopleServices : IPeople
    {
        private readonly ApartmentDbContextFactory _contextfactory = new ApartmentDbContextFactory();

        public PeopleServices()
        {
        }

        public async Task<PagedResult<CustomerVM>> GetAllPage(RequestPaging request)
        {
            using (AparmentDbContext _context = _contextfactory.CreateDbContext())
            {
                var query = from p in _context.People
                            select p;
                if (!string.IsNullOrEmpty(request.Keyword))
                {
                    query = query.Where(x => x.ID.Equals(request.Keyword) || x.Name.Contains(request.Keyword));
                }
                int totalRow = await query.CountAsync();
                var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .Select(x => new CustomerVM()
                    {
                        ID = x.ID,
                        Name = x.Name,
                        Sex = x.Sex,
                        Address = x.Address,
                        Birthday = x.Birthday,
                        Email = x.Email,
                        IDroom = x.IDroom,
                        IDCard =x.IDCard,
                        PhoneNumber = x.PhoneNumber,
                    }).ToListAsync();
                var pagedView = new PagedResult<CustomerVM>()
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