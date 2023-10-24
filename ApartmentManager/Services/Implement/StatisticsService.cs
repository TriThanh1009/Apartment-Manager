using Azure.Core;
using Data;
using Data.Entity;
using Microsoft.EntityFrameworkCore;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;
using ViewModel.Furniture;
using ViewModel.People;
using ViewModel.Statistic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Services.Implement
{
    public class StatisticsService : IStatistics
    {
        private readonly ApartmentDbContextFactory _ApartmentFactory;

        public StatisticsService(ApartmentDbContextFactory apartmentFactory)
        {
            _ApartmentFactory = apartmentFactory;
        }

        public async Task<PagedResult<StatisticsVm>> GetAllPage(RequestPaging request, int Month)
        {
            using (AparmentDbContext _context = _ApartmentFactory.CreateDbContext())
            {
                var query = from p in _context.Bill
                            join pt in _context.RentalContract on p.IDRTC equals pt.ID
                            join px in _context.Room on pt.IDroom equals px.ID
                            join pe in _context.PeopleRental on pt.ID equals pe.IDRental
                            join pp in _context.People on pe.IDPeople equals pp.ID
                            where p.PayDate.Month == Month
                            select new { p, pt, px, pp };
                int totalRow = await query.CountAsync();
                var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .Select(x => new StatisticsVm()
                    {
                        RoomName = x.px.Name,
                        LeaderName = x.pp.Name,
                        TotalMoney = (x.p.ElectricQuantity * x.pt.ElectricMoney) + (x.pt.WaterMoney * x.px.Quantity) + (x.pt.ServiceMoney * x.px.Quantity),
                        DatePaid = x.p.PayDate,
                    }).ToListAsync();
                var pagedView = new PagedResult<StatisticsVm>()
                {
                    TotalRecords = totalRow,
                    PageIndex = request.PageIndex,
                    PageSize = request.PageSize,
                    Items = data
                };
                return pagedView;
            }
        }

        public async Task<List<StatisticTotalMoney>> GetElectricAndWater(int Month)
        {
            using (AparmentDbContext _context = _ApartmentFactory.CreateDbContext())
            {
                var query = from p in _context.RentalContract
                            join pt in _context.Bill on p.ID equals pt.IDRTC
                            where pt.PayDate.Month == Month
                            select new { p, pt };

                var result = query.Select(x => new StatisticTotalMoney
                {
                    ElectricMoney = x.p.ElectricMoney,
                    WaterMoney = x.p.WaterMoney,
                }).ToList();
                return result;
            }
        }
    }
}