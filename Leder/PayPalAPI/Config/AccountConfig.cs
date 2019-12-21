using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Leder.PayPalAPI.Config
{
    public class AccountConfig
    {
        public static string PaypalEnv //production
        {
            get
            {
                if (string.IsNullOrEmpty(_paypalEnv))
                {
                    string value = ConfigurationManager.AppSettings["PaypalEnv"];
                    _paypalEnv = string.IsNullOrEmpty(value) ? "sandbox" : value;
                }
                return _paypalEnv;
            }
        }
        private static string _paypalEnv = "sandbox";
        public static bool IsSandbox = (PaypalEnv == "sandbox");

        public static string ClientId
        {
            get
            {
                if (IsSandbox) { return SandboxClientId; }
                return LiveClientId;
            }
        }

        public static string Secret
        {
            get
            {
                if (IsSandbox) return SandboxSecret;
                return LiveSecret;
            }
        }

        private static string SandboxClientId
        {
            get
            {
                if (string.IsNullOrEmpty(_sandboxClientId))
                {
                    string value = ConfigurationManager.AppSettings["SandboxClientId"];
                    _sandboxClientId = string.IsNullOrEmpty(value) ? string.Empty : value;
                }
                return _sandboxClientId;
            }
        }
        private static string _sandboxClientId = "AUaiHPKubOvW2WEVoToVgaTDf0XU6g8E3cb0pICGF1Y1tbDlzb6WKnenjVcUVPAV0opf7bk6dbXpHM_M";
        public static string SandboxSecret
        {
            get
            {
                if (string.IsNullOrEmpty(_sandboxSecret))
                {
                    string value = ConfigurationManager.AppSettings["SandboxSecret"];
                    _sandboxSecret = string.IsNullOrEmpty(value) ? string.Empty : value;
                }
                return _sandboxSecret;
            }
        }
        private static string _sandboxSecret = "EIUAMPb3Su0GZ6as0IrWcyw2aoScCDE10MyW8cr-usXLD8X7Si56vj3nlSE9TniK-Gs4FIIHwkvQbx3Q";

        private static string LiveClientId
        {
            get
            {
                if (string.IsNullOrEmpty(_liveClientId))
                {
                    string value = ConfigurationManager.AppSettings["LiveClientId"];
                    _liveClientId = string.IsNullOrEmpty(value) ? string.Empty : value;
                }
                return _liveClientId;
            }
        }
        private static string _liveClientId = string.Empty;
        public static string LiveSecret
        {
            get
            {
                if (string.IsNullOrEmpty(_liveSecret))
                {
                    string value = ConfigurationManager.AppSettings["LiveSecret"];
                    _liveSecret = string.IsNullOrEmpty(value) ? string.Empty : value;
                }
                return _liveSecret;
            }
        }
        private static string _liveSecret = string.Empty;
    }
}