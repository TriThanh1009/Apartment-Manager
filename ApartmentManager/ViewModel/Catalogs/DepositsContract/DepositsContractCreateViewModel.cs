using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.Catalogs.DepositsContract
{
    public class DepositsContractCreateViewModel
    {
        public int ID { get; set; }
        public int IDRoom { get; set; }
        public DateTime DepositsDate { get; set; }
        public DateTime ReceiveDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int Money { get; set; }
    }
}
