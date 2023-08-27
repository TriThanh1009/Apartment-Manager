using Data.Entity;
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
    public class Apartment
    {
        private readonly IPeople _Ipeople;

        public Apartment(IPeople Ipeople)
        {
            _Ipeople = Ipeople;
        }

        public async Task<List<CustomerVM>> GetAllcustomer()
        {
            RequestPaging a = new RequestPaging();
            a.Keyword=null;
            a.PageSize=100;
            a.PageIndex=1;
            PagedResult<CustomerVM> tes = await _Ipeople.GetAllPage(a);
            List<CustomerVM> data = tes.Items;
            return data;
        }
    }
}