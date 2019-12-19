using Leder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leder.ViewModels
{
    public class ProductViewModel
    {

        public int Id { get; set; }         //等於Model裡的ProductId
        public string Name { get; set; }    //產品名稱
        public decimal? Price { get; set; }    //產品價格
        public string Category { get; set; }   //產品類別
        public string[] Photos { get; set; }   //產品照片
        public string Description { get; set; } //產品頁面的敘述文字
       // public string[] ColorChoices { get; set; }//產品其他顏色



        }
}