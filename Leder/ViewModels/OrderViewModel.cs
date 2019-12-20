using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Leder.Models.Cart;

namespace Leder.ViewModels
{
    public class OrderViewModel
    {
        public string Email { get; set; }
        public string RecieverName { get; set; }
        public string RecieverPhone { get; set; }
        public string RecieverAddress { get; set; }
        public string RecieverZipCode { get; set; }
        public Cart Carts { get; set; }
        public IEnumerable<CartItem> CartItems { get; set; }
    }
}