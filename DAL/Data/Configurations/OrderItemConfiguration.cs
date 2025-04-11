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
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItme>
    {
        public void Configure(EntityTypeBuilder<OrderItme> builder)
        {
            builder.Property(x => x.TotalPrice).HasColumnType("decimal(8,1)");

            builder.HasOne(x => x.order).WithMany(x => x.Orders).HasForeignKey(x => x.OrderID);
        }
    }
}
