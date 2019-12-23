using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leder.PayPalAPI.Enums
{
    public struct ApprovedNameState
    {
        /// <summary>
        /// 支付用户不存在
        /// </summary>
        public const string INVALID_PAYER_ID = "INVALID_PAYER_ID";
        /// <summary>
        /// Paypal订单不存在
        /// </summary>
        public const string INVALID_RESOURCE_ID = "INVALID_RESOURCE_ID";
        /// <summary>
        /// 支付成功
        /// </summary>
        public const string PAYMENT_ALREADY_DONE = "PAYMENT_ALREADY_DONE";
    }
}