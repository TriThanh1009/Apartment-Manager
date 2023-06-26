using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Room
    {
        public int ID { get; set; }
        public string IDLeader { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string IDImage { get; set; }
        public RoomImage RoomImage { get; set; }
    }
}
