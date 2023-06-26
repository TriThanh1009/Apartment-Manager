using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class RoomDetailsConfiguration : IEntityTypeConfiguration<RoomDetails>
    {
        public void Configure(EntityTypeBuilder<RoomDetails> builder)
        {
            builder.ToTable("RoomDetails");
            builder.HasAlternateKey(x => new { x.IDFur, x.IDroom });
            builder.Property(x => x.IDFur).IsRequired();
            builder.Property(x => x.IDroom).IsRequired();
        }
    }
}
