using Data;
using Data.Entity;
using Services.Implement;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;
using ViewModel.People;

namespace AM.UI.Model
{
    public class PeopleModel
    {
        private IBaseControl<People> _people = new BaseControlServices<People>(new ApartmentDbContextFactory());
        private readonly IPeople _peopleService = new PeopleServices();

        public PeopleModel()
        { }

        public Task<PagedResult<CustomerVM>> GetAllPage(RequestPaging request)
        {
            return _peopleService.GetAllPage(request);
        }
    }
}