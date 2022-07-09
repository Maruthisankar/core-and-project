using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_project.Models
{
    public class Product
    {

        [Key]
        public int ProductID { get; set; }
        [Required]
        public string productName { get; set; }

        public float Price { get; set; }
        public string Brand { get; set; }
        public DateTime MaufactureDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
