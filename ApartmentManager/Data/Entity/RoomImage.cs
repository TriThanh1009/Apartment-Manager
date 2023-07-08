using Data.Relationships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class RoomImage
    {
        public int ID { get; set; }
        public int IDroom { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public Room? Room { get; set; }
    }
}