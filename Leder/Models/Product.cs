using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Leder.Models
{
    public class Product
    {  
        [Key]
        public int ProductId { get; set; } 
        public string Name { get; set; }    //產品名稱
        public int? Price { get; set; }    //產品價格NT$
        public int? CategoryId { get; set; }   //產品類別
        public string Photo { get; set; }   //產品照片
        public string Description { get; set; } //產品頁面的敘述文字

        //Navigation Property
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
       
    }
}