using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Leder.Models.Cart
{
    //因為購物車有可能同時購買多比商品，所以此類別的主要功能是拿來放一群CartItem
    //，Cart類別就是我們購物車的主要類別了，類別內容如下所述

    [Serializable]//可序列化
    public class Cart : IEnumerable<CartItem> //購物車類別
    {
        //建構值
        public Cart()
        {
            this.cartItems = new List<CartItem>();
        }

        //儲存所有商品
        private List<CartItem> cartItems;
        public int Count
        {
            get { return this.cartItems.Count; }
        }

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

        //新增一筆Prodct，使用ProdctId
        public bool AddProduct(int ProuctId)
        {
            var findItem = this.cartItems.Where(s=>s.Id ==ProuctId)
                                         .Select(s=>s)
                                         .FirstOrDefault();

            //判斷相同Id的CartItem是否已經存在購物車內
            if(findItem==default(Models.Cart.CartItem))
            {
                //不存在購物車內則新增一筆
                using (LederContext db = new LederContext())
                {
                    var product = (from s in db.Products
                                   where s.Id == ProuctId
                                   select s).FirstOrDefault();
                    if(product !=default(Models.Product))
                    {
                        this.AddProduct(product);
                    }
                }
            }
            else
            {   //存在購物車內，則增加數量
                findItem.Quantity += 1;
            }
            return true;
                
        }

        //新增一筆Prodct，使用Prodct物件
        public bool AddProduct(Product product)
        {
            //將Product轉為CartItem
            var cartItem = new Models.Cart.CartItem()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Photo = product.Photo,
                Quantity = 1
            };
            //加入CartItem至購物車
            this.cartItems.Add(cartItem);
            return true;
        }

        public IEnumerator<CartItem> GetEnumerator()
        {
            return ((IEnumerable<CartItem>)cartItems).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<CartItem>)cartItems).GetEnumerator();
        }
    }
}