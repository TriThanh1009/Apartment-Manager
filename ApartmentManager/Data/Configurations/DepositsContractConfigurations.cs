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
            throw new NotImplementedException();
        }
    }
}
