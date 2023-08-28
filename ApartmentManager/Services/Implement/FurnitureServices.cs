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
using ViewModel.People;
using ViewModel.Room;

namespace Services.Implement
{
    public class FurnitureServices : IFurniture
    {
        private readonly ApartmentDbContextFactory _contextfactory;
        public FurnitureServices(ApartmentDbContextFactory contextfactory)
        {
            _contextfactory = contextfactory;
        }
        public Task<int> CreateFurniture(FurnitureCreateViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteFurniture(int FurnitureId)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResult<FurnitureVm>> GetAllPage(RequestPaging request)
        {
            using (AparmentDbContext _context = _contextfactory.CreateDbContext())
            {
                var query = from p in _context.Furniture
                            select  p;
                int totalRow = await query.CountAsync();
                var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .Select(x => new FurnitureVm()
                    {
                        ID = x.ID,
                        Name = x.Name,
                    }).ToListAsync();
                var pagedView = new PagedResult<FurnitureVm>()
                {
                    TotalRecords = totalRow,
                    PageIndex = request.PageIndex,
                    PageSize = request.PageSize,
                    Items = data
                };
                return pagedView;
            }
        }

        public Task<int> UpdateFurniture(FurnitureUpdateViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
