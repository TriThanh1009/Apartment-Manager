using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.DepositsContract
{
    public class DepositsContractUpdateViewModel
    {
        public int ID { get; set; }
        public int IDRoom { get; set; }
        public DateTime DepositsDate { get; set; }
        public DateTime ReceiveDate { get; set; }
        public int CheckOutDate { get; set; }
        public int Money { get; set; }
    }
}
