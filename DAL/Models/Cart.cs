using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public  class Cart
    {
        [Key]
        public int CartId { get; set; }
        public DateTime CreatedDate { get; set; }

        [InverseProperty(nameof(AppUser.Carts))]
        public string? userid { get; set; }
        public AppUser user { get; set; }

        public ICollection<CartItem> Items { get; set; }
    }
}
