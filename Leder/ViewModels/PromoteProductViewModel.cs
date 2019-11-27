using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Leder.ViewModels
{
    public class PromoteProductViewModel
    {
        [Key]
        public string SectionId { get; set; }
        public string ProductName { get; set; }        
        public string PhotoUrl { get; set; }
        public string DiscountWord { get; set; }
        public string Statement { get; set; }
    }
}