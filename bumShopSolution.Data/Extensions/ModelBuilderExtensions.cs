using bumShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace bumShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of bumShopSolution" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of bumShopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description of bumShopSolution" }
                );
        }
    }
}
