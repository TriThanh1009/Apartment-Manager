using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Statistics : DomainObject
    {
        public int ElectricMoney { get; set; }

        public int WaterMoney { get; set; }

        public DateTime Date { get; set; }
    }
}
