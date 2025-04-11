using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal PriceProduct { get; set; }
        public int quantity { get; set; }
        public string Description { get; set; }

        public ICollection<CartItem> cartItmes { get; set; }

        public ICollection<OrderItme> orderItmes { get; set; }

        public ICollection<Evaluation>Evaluations { get; set; }


        [InverseProperty(nameof(Category.Products))]
        public int? CategoryId{ get; set; }
        public Category category { get; set; }


        [InverseProperty(nameof(Discounts.Products))]
        public int? DiscountID { get; set; }
        public Discounts discounts { get; set; }


        [InverseProperty(nameof(Employee.Products))]
        public int EmpId {  get; set; }
        public Employee employee { get; set; }

    }
}
