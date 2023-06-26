using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Data
{
    public class ApartmentDbContextFactory : IDesignTimeDbContextFactory<AparmentDbContext>
    {
        public AparmentDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("ApartmentSQL");
            var optionsBuilder = new DbContextOptionsBuilder<AparmentDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new AparmentDbContext(optionsBuilder.Options);
        }
    }
}
