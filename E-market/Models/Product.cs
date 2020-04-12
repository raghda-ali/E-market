using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_market.Models
{
    public class Product
    {
        public int id { get; set; }
        [Required(ErrorMessage ="you have enter your name")]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        public string Image { get; set; }
        [Required]
        public string Description { get; set; }
        [DisplayName("Category")]
        [Required]
        public int category_id { get; set; }
        public Category category { get; set; }
    }
}
