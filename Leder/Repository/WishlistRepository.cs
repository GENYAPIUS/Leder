using Leder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leder.Repository
{
    public class WishlistRepository
    {
      
        public List<Wishlist> GetCurrentWishlist(int productId)
        {
            LederContext db = new LederContext();
            ProductRepository Productrepo = new ProductRepository(db);

            var item = Productrepo.FirstOrDefault(x => x.ProductId == productId);




            if (HttpContext.Current != null)
            {
                if (HttpContext.Current.Session["Wishlist"] == null)
                {
                    HttpContext.Current.Session["Wishlist"] = new Wishlist();
                }
                return (List<Wishlist>)HttpContext.Current.Session["Wishlist"];
            }
            else
            {
                throw new InvalidOperationException("操作異常,請聯繫客服");
            }
        }


    }
}