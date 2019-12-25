using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leder.Models.Wishlist
{
    [Serializable]//可序列化
    public class Wishlist : IEnumerable<WishlistItem>
    {
        public Wishlist()
        {
            this.WishlistItem = new List<WishlistItem>();
        }
        private List<WishlistItem> WishlistItem;

        public bool AddProduct(int ProuctId)
        {
            var findItem = this.WishlistItem.Where(s => s.Id == ProuctId)
                                            .Select(s => s)
                                            .FirstOrDefault();
            //判斷相同Id的WishlistItem是否已經存在購物車內
            if (findItem == default(WishlistItem))
            {
                //不存在清單內則新增一筆
                using (LederContext db = new LederContext())
                {
                    var product = (from s in db.Products
                                   where s.ProductId == ProuctId
                                   select s).FirstOrDefault();
                    if (product != default(Product))
                    {
                        this.AddProduct(product);
                    }
                }
            }
           
            return true;

        }

        //更新慾望清單
        //新增一筆Prodct，使用Prodct物件
        public bool AddProduct(Product product)
        {
            //將Product轉為WishlistItem
            var wishlistItem = new WishlistItem()
            {
                Id = product.ProductId,
                Name = product.Name,
                Price = product.Price,
                Photo = product.Photos
               
            };
            //加入wishlistItem至慾望清單
            this.WishlistItem.Add(wishlistItem);
            return true;
        }


        //移除一筆Product，使用ProductId
        public bool RemoveProduct(int ProductId)
        {
            var findItem = this.WishlistItem.Where(s => s.Id == ProductId)
                                            .Select(s => s)
                                            .FirstOrDefault();

            //判斷相同Id的WishlistItem是否已經存在慾望清單內
            if (findItem == default(WishlistItem))
            {
                //不存在購物車不做任何動作
            }
            else
            {   //存在購物車內，將商品移除
                this.WishlistItem.Remove(findItem);
            }
            return true;
        }

        public IEnumerator<WishlistItem> GetEnumerator()
        {
            return ((IEnumerable<WishlistItem>)WishlistItem).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<WishlistItem>)WishlistItem).GetEnumerator();
        }
    }
}