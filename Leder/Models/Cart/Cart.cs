using System;
using System.Collections.Generic;

namespace Leder.Models.Cart
{
    //因為購物車有可能同時購買多比商品，所以此類別的主要功能是拿來放一群CartItem
    //，Cart類別就是我們購物車的主要類別了，類別內容如下所述

    [Serializable]//可序列化
    public class Cart //購物車類別
    {
        //建構值
        public Cart()
        {
            this.cartItems = new List<CartItem>();
        }

        //儲存所有商品
        public List<CartItem> cartItems;

        //取得商品總價
        public decimal TotalAmount
        {
            get 
            {
                decimal totalAmount = 0.0m;
                foreach(var cartItem in this.cartItems)
                {
                    totalAmount = totalAmount + cartItem.Amount;
                }
                return totalAmount;
            }
        }
    }
}