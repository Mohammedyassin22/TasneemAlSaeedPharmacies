using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class OrderItme
    {
        [Key]
        public int OrderItmeId { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }


        [InverseProperty(nameof(Order.Orders))]
        public int OrderID { get; set; }
        public Order order { get; set; }

        public ICollection<Products> Products { get; set; }
        
    }
}
