using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leder.Models
{
    public class HomePartialViewModel
    { 
        public string Section { get; set; }
        public string ClassSize { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string PhotoUrl { get; set; }   
        public decimal Discount { get; set; }
        public string Statement { get; set; }
        
    }
}