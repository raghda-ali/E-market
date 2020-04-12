using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_market.Models;

namespace E_market.ViewModels
{
    public class ProductCategoryViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}