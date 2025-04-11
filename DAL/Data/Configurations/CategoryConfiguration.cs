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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.CategoryId).UseIdentityColumn(1, 1);
            builder.Property(x => x.Sold).HasColumnType("decimal(10,2)");
            builder.HasOne(c => c.discounts).WithMany(d => d.Categories).HasForeignKey(c => c.discount);
        }
    }
}
