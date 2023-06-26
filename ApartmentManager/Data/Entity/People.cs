using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class People
    {
        public int ID { get; set; }
        public string IDroom {  get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber {  get; set; }
        public string Email { get; set; }

        public Room? Room { get; set; }

    }
}
