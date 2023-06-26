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
            throw new NotImplementedException();
        }
    }
}
