using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leder.Models
{
    public class Wishlist
    {
        public int Id { get; set; }    //商品編號
        public string Photo { get; set; }//商品名稱
        public string Name { get; set; }//商品名稱
        public decimal? Price { get; set; } //商品購買價格
    }
}