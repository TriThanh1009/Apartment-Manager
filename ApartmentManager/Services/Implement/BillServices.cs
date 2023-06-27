using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implement
{
    public class BillServices : IBill
    {
        public async Task<int> Add(string i)
        {
            return 1;
        }
    }
}