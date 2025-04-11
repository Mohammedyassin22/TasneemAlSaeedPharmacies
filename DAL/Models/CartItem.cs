using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class CartItem
    {
        [Key]
        public int CartItemId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        [InverseProperty(nameof(Cart.Items))]
        public int? CartId { get; set; }
        public Cart cart { get; set; }

        public ICollection<Products> products { get; set; }

    }
}
