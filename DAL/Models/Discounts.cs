using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Discounts
    {
        [Key]
        public int DiscountId { get; set; }
        public int Discount { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public ICollection<Products> Products { get; set; }

       public ICollection<Category> Categories { get; set; }

        [InverseProperty(nameof(Employee.Discounts))]
        public int? EmpId { get; set; }
        public Employee employee { get; set; }
    }

}