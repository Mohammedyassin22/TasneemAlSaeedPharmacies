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
    public class ProductConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.Property(x => x.ProductId).UseIdentityColumn(1, 1);
            builder.Property(x => x.Description).HasColumnType("nvarchar(max)");
            builder.Property(x => x.ProductName).HasColumnType("varchar(50)");
            builder.Property(x => x.PriceProduct).HasColumnType("decimal(5,1)"); // تحديد دقة العمود بشكل صحيح

            builder.HasOne(x => x.employee).WithMany(x => x.Products).HasForeignKey(x => x.EmpId);
            builder.HasOne(x => x.discounts).WithMany(x => x.Products).HasForeignKey(x => x.DiscountID);
            builder.HasOne(x => x.category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
            builder.HasMany(x => x.Evaluations).WithOne(x => x.Product).HasForeignKey(x => x.ProductId);
            builder.HasMany(x => x.orderItmes).WithMany(x => x.Products);
            builder.HasMany(x => x.cartItmes).WithMany(x => x.products);
        }

    }
}
