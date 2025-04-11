using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpEmail { get; set; }
        public string EmpPassword { get; set; }
        public string EmpComfirmPass { get; set; }
        public DateTime LoginDate { get; set; } = DateTime.Now;

        public ICollection<Products> Products { get; set; }

        public ICollection<Discounts> Discounts { get; set; }
    }
}
