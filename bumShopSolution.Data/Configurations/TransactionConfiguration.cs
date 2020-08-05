using bumShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace bumShopSolution.Data.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Entities.Transaction>
    {
        public void Configure(EntityTypeBuilder<Entities.Transaction> builder)
        {
            builder.ToTable("Transactions");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(x => x.AppUser).WithMany(pt => pt.Transactions).HasForeignKey(pt => pt.UserId);
        }
    }
}
