
using Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class StatisticsConfiguration : IEntityTypeConfiguration<Statistics>
    {
        public void Configure(EntityTypeBuilder<Statistics> builder)
        {
            builder.ToTable("Statistics");
            builder.HasKey(x => x.ID);
            builder.Property(x=>x.ElectricMoney).HasMaxLength(50);
            builder.Property(x=>x.WaterMoney).HasMaxLength(50);
            builder.Property(x=>x.Date).HasMaxLength(50);
        }
    }
}
