using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leder.ViewModels
{
    public class ProductsSectionViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public decimal? Price { get; set; }    
        public string Category { get; set; }   
        public string Photo { get; set; }   
        public string ProductPage { get; set; }
    }
}