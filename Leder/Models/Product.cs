using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leder.Models
{
    public class Product
    {  
        public int Id { get; set; }
        public string Name { get; set; }    //產品名稱
        public string Price { get; set; }    //產品價格NT$
        public string Category { get; set; }   //產品類別
        public string Photo { get; set; }   //產品照片
        public string MorePhotos { get; set; } //產品的其他美照(考慮用string[])
        public string Description { get; set; } //產品頁面的敘述文字


    }
}