using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.Room
{
    public class RoomCreateViewModel
    {
        public int ID { get; set; }
        public int IDLeader { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
