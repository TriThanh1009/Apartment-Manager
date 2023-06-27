using Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DepositsContractConfigurations : IEntityTypeConfiguration<DepositsContract>
    {
        public void Configure(EntityTypeBuilder<DepositsContract> builder)
        {
            builder.ToTable("DepositsContract");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired();
            builder.HasOne(x => x.Room).WithMany(x => x.DepositsContracts).HasForeignKey(x => x.IDRoom);
            builder.Property(x => x.DepositsDate).HasDefaultValue(DateTime.Now);
            builder.Property(x=>x.ReceiveDate).HasDefaultValue(DateTime.Now);
            builder.Property(x=>x.CheckOutDate).HasDefaultValue(DateTime.Now);
            builder.Property(x=>x.Money).HasMaxLength(50).HasMaxLength(50);
        }
    }
}
