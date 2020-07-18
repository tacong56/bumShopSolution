using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace bumShopSolution.Data.EF
{
    public class BumShopDbContextFactory : IDesignTimeDbContextFactory<BumShopDbContext>
    {
        public BumShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("bumShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<BumShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new BumShopDbContext(optionsBuilder.Options);
        }
    }
}
