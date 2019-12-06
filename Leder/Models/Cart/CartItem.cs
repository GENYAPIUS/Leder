using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leder.Models.Cart
{
    //此類別我們準備拿來儲存單一商品，類別中包含商品編號,商品名稱, 價格, 數量 與 小計

    [Serializable] //可序列化
    public class CartItem //購物車內單一商品類別
    {
        public int Id { get; set; }    //商品編號
        public string Name { get; set; }//商品名稱
        public decimal? Price { get; set; }//商品購買價格
        public int? Quantity { get; set; }//商品購買數量
        //商品小計
        public string Photo { get; set; }
        public decimal? Amount
        {
            get { return this.Price * this.Quantity; }
        }
        public string CartId { set; get; } //購物車編號(用來查詢的GUID)
    }
}