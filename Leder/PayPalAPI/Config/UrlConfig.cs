using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Leder.PayPalAPI.Config
{
    public class UrlConfig
    {
        public static string PaypalBaseUrl
        {
            get
            {
                if (AccountConfig.IsSandbox) return SandboxPaypalBaseUrl;
                return LivePaypalBaseUrl;
            }
        }
        public static string SandboxPaypalBaseUrl
        {
            get
            {
                if (string.IsNullOrEmpty(_sandboxPaypalBaseUrl))
                {
                    string value = ConfigurationManager.AppSettings["SandboxPaypalBaseUrl"];
                    _sandboxPaypalBaseUrl = string.IsNullOrEmpty(value) ? string.Empty : value;
                }
                return _sandboxPaypalBaseUrl;
            }
        }
        private static string _sandboxPaypalBaseUrl = "https://api.sandbox.paypal.com";

        public static string LivePaypalBaseUrl
        {
            get
            {
                if (string.IsNullOrEmpty(_livePaypalBaseUrl))
                {
                    string value = ConfigurationManager.AppSettings["LivePaypalBaseUrl"];
                    _livePaypalBaseUrl = string.IsNullOrEmpty(value) ? string.Empty : value;
                }
                return _livePaypalBaseUrl;
            }
        }
        private static string _livePaypalBaseUrl = string.Empty;

        public static string TokenUrl = $"{PaypalBaseUrl}/v1/oauth2/token/";
        public static string CreatePaymentUrl = $"{PaypalBaseUrl}/v1/payments/payment/";
        public static string ApprovedUrl = $"{PaypalBaseUrl}/v1/payments/payment/{{0}}/execute";
        public static string ShowPaymentDetailsUrl = $"{PaypalBaseUrl}/v1/payments/payment/{{0}}";
    }
}