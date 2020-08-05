using bumShopSolution.Data.Entities;
using Microsoft.AspNetCore.Identity;
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

            // any guid
            var ADMIN_ID = new Guid("E148F6C4-9281-474E-866D-F306B11399D1");
            // any guid, but nothing is against to use the same one
            var ROLE_ID = new Guid("A2719CE9-F1E5-41AA-8D0E-860995EF33C7");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = ROLE_ID,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Admintrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = ADMIN_ID,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "tacong56@gmail.com",
                NormalizedEmail = "tacong56@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456a@"),
                SecurityStamp = string.Empty,
                FirstName = "Ta",
                LastName = "Cong",
                Dob = new DateTime(1997, 06, 05)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }
    }
}
