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
    }
}