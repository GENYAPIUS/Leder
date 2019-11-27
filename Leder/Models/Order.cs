using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leder.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
    }
}