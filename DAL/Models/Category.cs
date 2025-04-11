using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public  class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int totalcategory { get; set; }
        public decimal Sold { get; set; }

        // Navigation Property for Discounts
       public int? discount { get; set; }
        public Discounts discounts { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}
