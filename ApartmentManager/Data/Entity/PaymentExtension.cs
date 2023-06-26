using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PaymentExtension
    {
        public int ID { get; set; }
        public int IDBill { get; set; }
        public DateTime Days { get; set; }
        public Bill? Bill { get; set; }
    }
}
