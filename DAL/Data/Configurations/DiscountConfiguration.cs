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
    public class DiscountConfiguration : IEntityTypeConfiguration<Discounts>
    {
        public void Configure(EntityTypeBuilder<Discounts> builder)
        {
            builder.Property(x => x.DiscountId).UseIdentityColumn(1, 1);
            builder.Property(x => x.Description).HasColumnType("nvarchar(max)");

            builder.HasOne(x => x.employee).WithMany(x => x.Discounts).HasForeignKey(x => x.EmpId);
        }
    }
}
