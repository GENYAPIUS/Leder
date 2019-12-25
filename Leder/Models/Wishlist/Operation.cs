using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Mvc;
using Leder.Repository;

namespace Leder.Models.Wishlist
{
    //慾望清單的頁面
    public class Operation
    {
        [WebMethod(EnableSession = true)] //啟用Session
        public static Wishlist GetCurrentWishlist(int id)
        {
            private LederContext db = new LederContext();
            private ProductRepository productRepo;

            List<WishlistItem> wishlistItem = new List<WishlistItem>();

            if (Session["Wishlist"] == null) //一開始購物車沒東西
            {
                WishlistItem WishItems = new WishlistItem
                {
                    Id = id,
                    Name
                    
                    Price = productVM.Price,
                    Count = productVM.Count,
                    CreatedDate = DateTime.Now
                };

                wishlistItem.Add(WishItems);

            }
            else
            {
                wishlistItem = (List<WishlistItem>)Session["Cart"];  //將Session中的購物車記錄還原成集合

                WishlistItem WishItems = new WishlistItem
                {
                    RecordId = cartItems.Count() + 1,
                    CartId = Guid.NewGuid().ToString(),
                    ProductId = productVM.ProductId,
                    Price = productVM.Price,
                    Count = productVM.Count,
                    CreatedDate = DateTime.Now
                };

                wishlistItem.Add(WishItems);

                Session["CartItemCount"] = cart.RecordId;
                //保持記錄著購物車的商品，因為Session是存在server裡的
            }

            //這邊設中斷點看看
            Session["Cart"] = cartItems; //購物車每新增一筆商品資料(cart)，RecordId會記錄裡面有幾筆資料


            return (Cart)cache[UserId];  //類似塞資料


        }



    }
}