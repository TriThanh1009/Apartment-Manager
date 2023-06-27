using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed (this ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Account>().HasData(
                new Account() { ID = 1, Acc = "admin", Pass = "admin" });
        }
    }
}
