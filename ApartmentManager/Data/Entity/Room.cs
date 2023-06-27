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
        public int IDLeader { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string IDImage { get; set; }
        public RoomImage? RoomImage { get; set; }

        public ICollection<RoomImage> RoomImages { get; } = new List<RoomImage>();

        public ICollection<People> People { get; } = new List<People>();

        public ICollection<RentalContract> RentalContracts { get; } = new List<RentalContract>();
        public ICollection<DepositsContract> DepositsContracts { get; } = new List<DepositsContract>();


    }
}
