using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leder.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }    //商品名稱
        public string Category { get; set; }   //產品類別
        public string Photo { get; set; }   //照片
        public string ProductPage { get; set; } //連到單個商品的Url

    }
}