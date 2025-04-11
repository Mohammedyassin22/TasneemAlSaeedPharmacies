using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceNumber { get; set; }
        public string TripleName { get; set; }
        public string FirstPhone { get; set; }
        public string SecondPhone { get; set; }
        public string Address { get; set; }
        public bool PaymentStatus { get; set; }
        public decimal TotalOrder { get; set; }

        [InverseProperty(nameof(AppUser.Invoices))]
        public string? userid { get; set; }
        public AppUser User { get; set; }

        [InverseProperty(nameof(Order.Invoice))]
         public int orderId {  get; set; }
        public Order Order { get; set; }
    }
}
