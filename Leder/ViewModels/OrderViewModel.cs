using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Leder.Models.Cart;

namespace Leder.ViewModels
{
    public class OrderViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]        
        [StringLength(30, ErrorMessage = "{0} 的長度至少必須為 {2} 個字元。"
           , MinimumLength = 2)]
        public string RecieverName { get; set; }
        [Required]        
        [StringLength(15, ErrorMessage = "{0} 的長度至少必須為 {8} 個字元。"
            , MinimumLength = 8)]
        public string RecieverPhone { get; set; }
        [Required]        
        [StringLength(256, ErrorMessage = "{0} 的長度至少必須為 {2} 個字元。"
            , MinimumLength = 2)]
        public string RecieverAddress { get; set; }
        [Required]
        [StringLength(5, ErrorMessage = "{0} 的長度至少必須為 {3} 個字元。"
            , MinimumLength = 3)]
        public string RecieverZipCode { get; set; }
        
        public string PayStatus { get; set; }
        
        public Cart Carts { get; set; }
        
        public IEnumerable<CartItem> CartItems { get; set; }
    }
}