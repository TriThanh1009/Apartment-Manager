using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Bill
    {
        public int ID { get; set; }
        public int IDRTC {  get; set; }
        public int ElectricQuantity { get; set; }
        public string Active {  get; set; }
        public DateTime PayDate { get; set; }
        public int TotalMoney { get; set; }

        public RentalContract? RentalContract { get; set; }
        public ICollection<PaymentExtension> PaymentExtensions { get; } = new List<PaymentExtension>();

    }
}
