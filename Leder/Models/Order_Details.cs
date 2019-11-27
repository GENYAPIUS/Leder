using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leder.Models
{
    public partial class Order_Details
    {
        public int Order_DetailsId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}