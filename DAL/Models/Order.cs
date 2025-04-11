using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public enum OrderStatus
    { 
        Processing = 1,    // تحت التنفيذ
        Shipped = 2,       // تم الشحن
        Delivered = 3,     // تم التوصيل
        Cancelled = 4      // تم الإلغاء
    }

    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderTime {  get; set; }

        public Invoice Invoice { get; set; }

        [InverseProperty(nameof(AppUser.Orders))]
        public string? Userid { get; set; }
        public AppUser appuser { get; set; }

       public ICollection<OrderItme> Orders { get; set; }

        public OrderStatus OrderStatus { get; set; }
    }

}
