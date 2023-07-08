using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entity;

namespace Data.Relationships
{
    public class RoomDetails
    {
        public int IDFur { get; set; }
        public int IDRoom { get; set; }
        public int IDImage { get; set; }

        public RoomImage? RoomImage { get; set; }
        public Furniture? Furniture { get; set; }
        public Room? Room { get; set; }
    }
}