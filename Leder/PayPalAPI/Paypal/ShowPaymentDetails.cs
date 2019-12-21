using Leder.Models;
using Leder.PayPalAPI.Config;
using System.Text;
using System.Web.Script.Serialization;

namespace Leder.PayPalAPI.Paypal
{
    public class ShowPaymentDetails
    {
        public PaymentResult Do(string paymentId)
        {
            var json = HttpHelper.Get(
                string.Format(UrlConfig.ShowPaymentDetailsUrl, paymentId),
                AccountConfig.ClientId, AccountConfig.Secret,
                Encoding.UTF8);
            var result = new JavaScriptSerializer().Deserialize<PaymentResult>(json);
            return result;
        }
    }
}