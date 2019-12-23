using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leder.Models
{
    public class PaymentResult
    {
        public string id { get; set; }
        public string create_time { get; set; }
        public string update_time { get; set; }
        public string state { get; set; }
        public string intent { get; set; }
        public dynamic payer { get; set; }
        public List<PaymentTransaction> transactions { get; set; }
        public List<PaymentLink> links { get; set; }
    }

    public class PaymentLink
    {
        public string href { get; set; }
        public string rel { get; set; }
        public string method { get; set; }
    }

    public class PaymentTransaction
    {
        public string custom { get; set; }
        public string description { get; set; }
        public dynamic amount { get; set; }
        public string invoice_number { get; set; }
        public dynamic item_list { get; set; }
    }
}