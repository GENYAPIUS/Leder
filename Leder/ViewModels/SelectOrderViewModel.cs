using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Leder.ViewModels
{
    public class SelectOrderViewModel
    {
        [Key]
        public Guid OrderId { get; set; }
        public string Email { get; set; } // 使用者Id        
        public string RecieverName { get; set; }

        public string RecieverPhone { get; set; }

        public string RecieverAddress { get; set; }

        public string OrderDate { get; set; }
        
        public string RecieverZipCode { get; set; }

        public decimal? TotalAmount { get; set; }
        
        public string PayStatus { get; set; }

        public string OrderStatus { get; set; }
    }
}