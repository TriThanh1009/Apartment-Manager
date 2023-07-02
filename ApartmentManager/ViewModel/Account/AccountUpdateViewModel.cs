using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.Account
{
    public class AccountUpdateViewModel
    {
        public int ID { get; set; }
        public string Acc { get; set; }
        public string Pass { get; set; }
        public int Permission { get; set; }
    }
}
