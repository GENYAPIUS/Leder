using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Leder.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal? Price { get; set; }
        public int Amount { get; set; }
        public decimal Discount { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}