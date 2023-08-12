using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;
using ViewModel.People;

namespace Services.Interface
{
    public interface IPeople
    {
        Task<PagedResult<CustomerVM>> GetAllPage(RequestPaging request);

        Task<List<CustomerVM>> GetAll();

        Task<People> Edit(int id, PeopleUpdateViewModel request);

        Task<bool> Delete(int id);

        Task<People> Create(PeopleCreateViewModel request);
    }
}