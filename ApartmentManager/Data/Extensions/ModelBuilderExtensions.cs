using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entity;
using Data.Enum;
using Data.Relationships;

namespace Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Account>().HasData(
                new Account() { Acc = "admin", Pass = "admin" });
            modelbuilder.Entity<Bill>().HasData(
                new Bill() { ID = 2, IDRTC = 1, ElectricQuantity = 150, Active = Active.Yes, PayDate = DateTime.Now, TotalMoney = 1000000 });
            modelbuilder.Entity<DepositsContract>().HasData(
                new DepositsContract { ID = 1, IDRoom = 1, DepositsDate = DateTime.Now, ReceiveDate = DateTime.Now, CheckOutDate = DateTime.Now, Money = 10000 });
            modelbuilder.Entity<Furniture>().HasData(
                new Furniture { ID = 1, Name="Chair" });
            modelbuilder.Entity<PaymentExtension>().HasData(
                new PaymentExtension { ID = 1, IDBill = 1, Days = DateTime.Now });
            modelbuilder.Entity<People>().HasData
                (new People() { ID=1, IDroom=1, Name = "Jonhny Deep", Birthday = DateTime.Now, Email = "thanh@gmail.com", PhoneNumber="1234", IDCard="1234123", Address="Vietnam" });
            modelbuilder.Entity<RentalContract>().HasData(
                new RentalContract { ID = 1, IDroom = 1, IDLeader = 1, ReceiveDate = DateTime.Now, CheckOutDate = DateTime.Now, RoomMoney = 100, ElectricMoney = 100, WaterMoney = 100, ServiceMoney = 100 });
            modelbuilder.Entity<Room>().HasData(
                new Room { ID = 1, Name = "A201", IDLeader = 0, Quantity = 4 },
                new Room { ID = 2, Name = "A202", IDLeader = 0, Quantity = 5 },
                new Room { ID = 3, Name = "A203", IDLeader = 0, Quantity = 3 },
                new Room { ID = 4, Name = "A204", IDLeader = 0, Quantity = 3 },
                new Room { ID = 5, Name = "A205", IDLeader = 0, Quantity = 4 },
                new Room { ID = 6, Name = "A206", IDLeader = 0, Quantity = 4 },
                new Room { ID = 7, Name = "A207", IDLeader = 0, Quantity = 3 },
                new Room { ID = 8, Name = "A208", IDLeader = 0, Quantity = 5 },
                new Room { ID = 9, Name = "A209", IDLeader = 0, Quantity = 5 },
                new Room { ID = 10, Name = "A210", IDLeader = 0, Quantity = 3 },
                new Room { ID = 11, Name = "A211", IDLeader = 0, Quantity = 5 },
                new Room { ID = 12, Name = "A212", IDLeader = 0, Quantity = 3 },
                new Room { ID = 13, Name = "A213", IDLeader = 0, Quantity = 4 },
                new Room { ID = 14, Name = "A214", IDLeader = 0, Quantity = 4 },
                new Room { ID = 15, Name = "A215", IDLeader = 0, Quantity = 3 },
                new Room { ID = 16, Name = "A216", IDLeader = 0, Quantity = 4 },
                new Room { ID = 17, Name = "A217", IDLeader = 0, Quantity = 3 },
                new Room { ID = 18, Name = "A218", IDLeader = 0, Quantity = 3 },
                new Room { ID = 19, Name = "A219", IDLeader = 0, Quantity = 5 },
                new Room { ID = 20, Name = "A220", IDLeader = 0, Quantity = 4 },
                new Room { ID = 21, Name = "A221", IDLeader = 0, Quantity = 4 },
                new Room { ID = 22, Name = "A222", IDLeader = 0, Quantity = 5 },
                new Room { ID = 23, Name = "A223", IDLeader = 0, Quantity = 5 },
                new Room { ID = 24, Name = "A224", IDLeader = 0, Quantity = 3 },
                new Room { ID = 25, Name = "A225", IDLeader = 0, Quantity = 4 },
                new Room { ID = 26, Name = "A226", IDLeader = 0, Quantity = 3 },
                new Room { ID = 27, Name = "A227", IDLeader = 0, Quantity = 5 },
                new Room { ID = 28, Name = "A228", IDLeader = 0, Quantity = 3 },
                new Room { ID = 29, Name = "A229", IDLeader = 0, Quantity = 4 },
                new Room { ID = 30, Name = "A230", IDLeader = 0, Quantity = 5 },
                new Room { ID = 31, Name = "A231", IDLeader = 0, Quantity = 4 },
                new Room { ID = 32, Name = "A232", IDLeader = 0, Quantity = 5 },
                new Room { ID = 33, Name = "A233", IDLeader = 0, Quantity = 4 },
                new Room { ID = 34, Name = "A234", IDLeader = 0, Quantity = 3 },
                new Room { ID = 35, Name = "A235", IDLeader = 0, Quantity = 4 },
                new Room { ID = 36, Name = "A236", IDLeader = 0, Quantity = 5 },
                new Room { ID = 37, Name = "A237", IDLeader = 0, Quantity = 4 },
                new Room { ID = 38, Name = "A238", IDLeader = 0, Quantity = 3 },
                new Room { ID = 39, Name = "A239", IDLeader = 0, Quantity = 5 },
                new Room { ID = 40, Name = "A240", IDLeader = 0, Quantity = 3 });
            modelbuilder.Entity<RoomImage>().HasData(
                new RoomImage { ID=1, IDroom=1, Name="A1 Image", Url="www.goole.com" });
            modelbuilder.Entity<RoomDetails>().HasData(
                new RoomDetails { IDFur = 1, IDRoom = 1},
                new RoomDetails { IDFur = 2, IDRoom = 2 },
                new RoomDetails { IDFur = 3, IDRoom = 3 },
                new RoomDetails { IDFur = 2, IDRoom = 4 },
                new RoomDetails { IDFur = 3, IDRoom = 5 },
                new RoomDetails { IDFur = 1, IDRoom = 6 },
                new RoomDetails { IDFur = 3, IDRoom = 7 }
                );
        }
    }
}