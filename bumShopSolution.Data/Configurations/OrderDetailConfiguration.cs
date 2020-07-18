using bumShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace bumShopSolution.Data.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");
            builder.HasKey(o => new { o.OrderId, o.ProductId });
            builder.HasOne(o => o.Order).WithMany(pt => pt.OrderDetails)
                .HasForeignKey(pt => pt.OrderId);
            builder.HasOne(o => o.Product).WithMany(pt => pt.orderDetails)
                .HasForeignKey(pt => pt.ProductId);
        }
    }
}
