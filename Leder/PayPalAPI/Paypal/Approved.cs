using Leder.Models;
using Leder.PayPalAPI.Config;
using System.Web.Script.Serialization;
using System.Text;

namespace Leder.PayPalAPI.Paypal
{
    public class Approved
    {
        public PaymentResult DoJson(string paymentId, dynamic json)
        {
            var jsonResult = HttpHelper.PostJson(string.Format(UrlConfig.ApprovedUrl, paymentId),
                AccountConfig.ClientId, AccountConfig.Secret, json, Encoding.UTF8);
            var result = new JavaScriptSerializer().Deserialize<PaymentResult>(jsonResult);
            return result;
        }

        public PaymentResult Do(string paymentId, string payerId)
        {
            var json = GetPayParams(payerId);
            return DoJson(paymentId, json);
        }

        public string GetPayParams(string payerId)
        {
            var payParams = new
            {
                payer_id = payerId
            };
            var json = new JavaScriptSerializer().Serialize(payParams);
            return json;
        }
    }
}