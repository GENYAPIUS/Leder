using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Leder.Models
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }
        public string Email { get; set; } // 使用者Id
        /// <summary>
        /// 收貨人姓名
        /// </summary>
        [Required]
        [Display(Name = "收貨人姓名")]
        [StringLength(30, ErrorMessage = "{0} 的長度至少必須為 {2} 個字元。"
            , MinimumLength = 2)] //字元長度2~30
        public string RecieverName { get; set; }

        /// <summary>
        /// 收貨人電話
        /// </summary>
        [Required]
        [Display(Name = "收貨人電話")]
        [StringLength(15, ErrorMessage = "{0} 的長度至少必須為 {8} 個字元。"
            , MinimumLength = 8)] //字元長度8~15
        public string RecieverPhone { get; set; }

        /// <summary>
        /// 收貨人住址
        /// </summary>
        [Required]
        [Display(Name = "收貨人地址")]
        [StringLength(256, ErrorMessage = "{0} 的長度至少必須為 {2} 個字元。"
            , MinimumLength = 2)] //字元長度2~256
        public string RecieverAddress { get; set; }

        /// <summary>
        /// 收貨人郵遞區號
        /// </summary>
        public DateTime OrderDate { get; set; }
        [Required]
        [Display(Name = "郵遞區號")]
        [StringLength(5, ErrorMessage = "{0} 的長度至少必須為 {3} 到 {5} 個字元。"
           , MinimumLength = 3)] //字元長度3~5
        public string RecieverZipCode { get; set; }

        /// <summary>
        /// 總金額
        /// </summary>
        public decimal? TotalAmount { get; set; }
        /// <summary>
        /// 付款方式
        /// </summary>
        public string PayStatus { get; set; }

        /// <summary>
        /// 訂單狀態
        /// </summary>
        public string OrderStatus { get; set; }  
    }
}