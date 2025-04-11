using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Configurations
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.Property(x => x.InvoiceNumber).UseIdentityColumn(1, 1);
            builder.Property(x => x.Address).HasColumnType("nvarchar(max)");
            builder.Property(x => x.FirstPhone).HasColumnType("nvarchar(max)");
            builder.Property(x => x.SecondPhone).HasColumnType("nvarchar(max)");
            builder.Property(x => x.TripleName).HasColumnType("nvarchar(max)");
            builder.Property(x => x.TotalOrder).HasColumnType("decimal(8,1)");

            builder.HasOne(x=>x.User).WithMany(x=>x.Invoices).HasForeignKey(x=>x.userid);
            builder.HasOne(x => x.Order).WithOne(x => x.Invoice).HasForeignKey<Invoice>(x => x.orderId);
        }
    }
}
