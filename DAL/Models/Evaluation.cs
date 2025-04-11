using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Evaluation
    {
        [Key]
        public int Rating { get; set; }
        public DateTime RatingTime { get; set; }= DateTime.Now;

        public int? ProductId { get; set; }
        public Products Product { get; set; }

        public string? UserName {  get; set; }
        public AppUser appuser { get; set; }
    }
}
