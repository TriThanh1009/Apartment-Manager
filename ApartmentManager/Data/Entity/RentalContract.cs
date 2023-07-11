using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class RentalContract : DomainObject
    {
        public int IDroom { get; set; }
        public int IDLeader { get; set; }
        public DateTime ReceiveDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int RoomMoney { get; set; }
        public int ElectricMoney { get; set; }
        public int WaterMoney { get; set; }
        public int ServiceMoney { get; set; }
        public Room? Room { get; set; }

        public ICollection<Bill> Bills { get; } = new List<Bill>();
    }
}