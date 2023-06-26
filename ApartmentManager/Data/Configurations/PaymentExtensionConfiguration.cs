using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    public class PaymentExtensionConfiguration : IEntityTypeConfiguration<PaymentExtension>
    {
        public void Configure(EntityTypeBuilder<PaymentExtension> builder)
        {
            throw new NotImplementedException();
        }
    }
}
