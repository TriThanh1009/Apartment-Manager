using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data.Enum;

namespace Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed (this ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Account>().HasData(
                new Account() { ID = 1, Acc = "admin", Pass = "admin" });
            modelbuilder.Entity<Bill>().HasData(
                new Bill() { ID = 2, IDRTC = 1, ElectricQuantity = 150, Active = Active.Yes, PayDate = DateTime.Now, TotalMoney = 1000000 });
            modelbuilder.Entity<DepositsContract>().HasData(
                new DepositsContract { ID = 1, IDRoom = 1, DepositsDate = DateTime.Now, ReceiveDate = DateTime.Now, CheckOutDate = DateTime.Now, Money = 10000 });
            modelbuilder.Entity<Furniture>().HasData(
                new Furniture { ID = 1, Name="Chair"});
            modelbuilder.Entity<PaymentExtension>().HasData(
                new PaymentExtension { ID = 1, IDBill = 1, Days = DateTime.Now });
            modelbuilder.Entity<People>().HasData(new
                People() {ID=1,IDroom=1,Name = "Jonhny Deep", Birthday = DateTime.Now, Email = "thanh@gmail.com",PhoneNumber="1234",IDCard="1234123",Address="Vietnam"});

        }
    }
}
