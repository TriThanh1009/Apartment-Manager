using Data.Configurations;
using Data.Relationships;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AparmentDbContext : DbContext
    {
        public AparmentDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new BillConfiguration());
            modelBuilder.ApplyConfiguration(new DepositsContractConfigurations());
            modelBuilder.ApplyConfiguration(new FurnitureConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentExtensionConfiguration());
            modelBuilder.ApplyConfiguration(new PeopleConfiguration());
            modelBuilder.ApplyConfiguration(new RentalContractConfiguration());
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
            modelBuilder.ApplyConfiguration(new RoomDetailsConfiguration());
            modelBuilder.ApplyConfiguration(new RoomImageConfiguration());
            //modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Account> Account { get; set; }
        public DbSet<Bill> Bill { get; set; }
        public DbSet<DepositsContract> DepositsContract { get; set; }
        public DbSet<Furniture> Furniture { get; set; }
        public DbSet<PaymentExtension> PaymentExtension { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<RentalContract> RentalContract { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomDetails> RoomDetail { get; set; }
        public DbSet<RoomImage> RoomImage { get; set; }
    }
}