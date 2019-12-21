using Leder.PayPalAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leder.Models
{
    public class PaymentParam
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Total { get; set; }
        public PaypalCurrency Currency { get; set; }
        public string ReturnUrl { get; set; }
        public string CancelUrl { get; set; }
    }
}