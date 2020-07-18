using bumShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace bumShopSolution.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");
            builder.HasKey(o => new { o.CategoryId, o.ProductId });
            builder.HasOne(o => o.Product).WithMany(pt => pt.productInCategories)
                .HasForeignKey(pt => pt.ProductId);
            builder.HasOne(o => o.Category).WithMany(pt => pt.productInCategories)
                .HasForeignKey(pt => pt.CategoryId);
        }
    }
}
