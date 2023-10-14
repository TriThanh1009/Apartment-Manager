using Data.Entity;
using Data.Enum;
using Data.Relationships;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Account>().HasData(
                new Account() { ID = 1, Acc = "admin", Pass = "admin" });
            modelbuilder.Entity<Bill>().HasData(
                new Bill() { ID = 1, IDRTC = 1, ElectricQuantity = 150, Active = Active.Yes, PayDate = DateTime.Now, TotalMoney = 1000000 });
            modelbuilder.Entity<DepositsContract>().HasData(
                new DepositsContract { ID = 1, IDRoom = 1, DepositsDate = DateTime.Now, ReceiveDate = DateTime.Now, CheckOutDate = DateTime.Now, Money = 10000 });
            modelbuilder.Entity<Furniture>().HasData(
                new Furniture { ID = 1, Name = "Chair" });
            modelbuilder.Entity<PaymentExtension>().HasData(
                new PaymentExtension { ID = 1, IDBill = 1, Days = DateTime.Now });
            modelbuilder.Entity<People>().HasData
                (new People() { ID = 1, Name = "Jonhny Deep", Birthday = DateTime.Now, Email = "thanh@gmail.com", PhoneNumber = "1234", IDCard = "1234123", Address = "Vietnam" },
                new People() { ID = 2, Name = "Emily Stone", Birthday = new DateTime(new Random().Next(1990, 2001), new Random().Next(1, 13), new Random().Next(1, 29)), Email = "emily@gmail.com", PhoneNumber = "5678", IDCard = "56781234", Address = "USA" },
                new People() { ID = 3, Name = "Robert Smith", Birthday = new DateTime(new Random().Next(1990, 2001), new Random().Next(1, 13), new Random().Next(1, 29)), Email = "robert@gmail.com", PhoneNumber = "91011", IDCard = "910111213", Address = "Canada" },
                new People() { ID = 4, Name = "Anna Johnson", Birthday = new DateTime(new Random().Next(1990, 2001), new Random().Next(1, 13), new Random().Next(1, 29)), Email = "anna@gmail.com", PhoneNumber = "1415", IDCard = "14151617", Address = "Australia" },
                new People() { ID = 5, Name = "Michael Brown", Birthday = new DateTime(new Random().Next(1990, 2001), new Random().Next(1, 13), new Random().Next(1, 29)), Email = "michael@gmail.com", PhoneNumber = "1819", IDCard = "18192021", Address = "UK" });
            modelbuilder.Entity<RentalContract>().HasData(
                new RentalContract { ID = 1, IDroom = 1, IDLeader = 1, ReceiveDate = DateTime.Now, CheckOutDate = DateTime.Now, RoomMoney = 100, ElectricMoney = 100, WaterMoney = 100, ServiceMoney = 100 });
            modelbuilder.Entity<Room>().HasData(
                new Room { ID = 1, Name = "A201", Quantity = 4 },
                new Room { ID = 2, Name = "A202", Quantity = 5 },
                new Room { ID = 3, Name = "A203", Quantity = 3 },
                new Room { ID = 4, Name = "A204", Quantity = 3 },
                new Room { ID = 5, Name = "A205", Quantity = 4 },
                new Room { ID = 6, Name = "A206", Quantity = 4 },
                new Room { ID = 7, Name = "A207", Quantity = 3 },
                new Room { ID = 8, Name = "A208", Quantity = 5 },
                new Room { ID = 9, Name = "A209", Quantity = 5 },
                new Room { ID = 10, Name = "A210", Quantity = 3 },
                new Room { ID = 11, Name = "A211", Quantity = 5 },
                new Room { ID = 12, Name = "A212", Quantity = 3 },
                new Room { ID = 13, Name = "A213", Quantity = 4 },
                new Room { ID = 14, Name = "A214", Quantity = 4 },
                new Room { ID = 15, Name = "A215", Quantity = 3 },
                new Room { ID = 16, Name = "A216", Quantity = 4 },
                new Room { ID = 17, Name = "A217", Quantity = 3 },
                new Room { ID = 18, Name = "A218", Quantity = 3 },
                new Room { ID = 19, Name = "A219", Quantity = 5 },
                new Room { ID = 20, Name = "A220", Quantity = 4 },
                new Room { ID = 21, Name = "A221", Quantity = 4 },
                new Room { ID = 22, Name = "A222", Quantity = 5 },
                new Room { ID = 23, Name = "A223", Quantity = 5 },
                new Room { ID = 24, Name = "A224", Quantity = 3 },
                new Room { ID = 25, Name = "A225", Quantity = 4 },
                new Room { ID = 26, Name = "A226", Quantity = 3 },
                new Room { ID = 27, Name = "A227", Quantity = 5 },
                new Room { ID = 28, Name = "A228", Quantity = 3 },
                new Room { ID = 29, Name = "A229", Quantity = 4 },
                new Room { ID = 30, Name = "A230", Quantity = 5 },
                new Room { ID = 31, Name = "A231", Quantity = 4 },
                new Room { ID = 32, Name = "A232", Quantity = 5 },
                new Room { ID = 33, Name = "A233", Quantity = 4 },
                new Room { ID = 34, Name = "A234", Quantity = 3 },
                new Room { ID = 35, Name = "A235", Quantity = 4 },
                new Room { ID = 36, Name = "A236", Quantity = 5 },
                new Room { ID = 37, Name = "A237", Quantity = 4 },
                new Room { ID = 38, Name = "A238", Quantity = 3 },
                new Room { ID = 39, Name = "A239", Quantity = 5 },
                new Room { ID = 40, Name = "A240", Quantity = 3 });
            modelbuilder.Entity<RoomImage>().HasData(
                new RoomImage { ID = 1, IDroom = 1, Name = "A1 Image", Url = "D:jett.png" },
                new RoomImage { ID = 2, IDroom = 1, Name = "A2 Image", Url = "D:home.png" });
            modelbuilder.Entity<RoomDetails>().HasData(
                new RoomDetails { IDFur = 1, IDRoom = 1 },
                new RoomDetails { IDFur = 1, IDRoom = 2 },
                new RoomDetails { IDFur = 1, IDRoom = 3 },
                new RoomDetails { IDFur = 1, IDRoom = 4 },
                new RoomDetails { IDFur = 1, IDRoom = 5 },
                new RoomDetails { IDFur = 1, IDRoom = 6 },
                new RoomDetails { IDFur = 1, IDRoom = 7 }
                );
            modelbuilder.Entity<PeopleRental>().HasData(
                new PeopleRental { ID = 1, IDPeople = 2, IDRental = 1, Membership = Membership.Leader },
                new PeopleRental { ID = 2, IDPeople = 3, IDRental = 1, Membership = Membership.Member },
                new PeopleRental { ID = 3, IDPeople = 4, IDRental = 1, Membership = Membership.Member },
                new PeopleRental { ID = 4, IDPeople = 5, IDRental = 1, Membership = Membership.Member }
                );
        }
    }
}