using Leder.Models;
using Leder.PayPalAPI.Config;
using System.Collections.Generic;
using System.Text;
using System.Web.Script.Serialization;

namespace Leder.PayPalAPI.Paypal
{
    public class Token
    {
        public TokenResult GetToken()
        {
            var json = HttpHelper.PostForm(UrlConfig.TokenUrl, AccountConfig.ClientId, AccountConfig.Secret,
                new Dictionary<string, object> { { "grant_type", "client_credentials" } },
                Encoding.UTF8);
            var result = new JavaScriptSerializer().Deserialize<TokenResult>(json);
            return result;
        }
    }
}