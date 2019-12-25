using Leder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leder.Repository
{
    public class WishlistRepository
    {

        public List<Wishlist> GetCurrentWishlist()
        {           

            List<Wishlist> wishlists = new List<Wishlist>();            

            if (HttpContext.Current.Session["Wishlist"] == null)
            {                
                HttpContext.Current.Session["Wishlist"] = wishlists;
            }
            else
            {
                wishlists = (List<Wishlist>)HttpContext.Current.Session["Wishlist"];               
                
            }
            return wishlists;

        }      



    }
}