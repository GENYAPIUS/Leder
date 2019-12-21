using System;
using System.Text;
using System.Web.Script.Serialization;
using Leder.PayPalAPI.Config;
using Leder.PayPalAPI.Enums;
using Leder.Models;

namespace Leder.PayPalAPI.Paypal
{
    /// <summary>
    /// CreatePayment 的摘要说明
    /// </summary>
    public class CreatePayment
    {
        public CreatePayment()
        {
        }

        public PaymentResult Pay(string json)
        {
            var jsonResult = HttpHelper.PostJson(
                UrlConfig.CreatePaymentUrl,
                AccountConfig.ClientId, AccountConfig.Secret, json,
                Encoding.UTF8);
            var result = new JavaScriptSerializer().Deserialize<PaymentResult>(jsonResult);
            return result;
        }

        public PaymentResult Pay(PaymentParam param)
        {
            var json = GetPayParams(param);
            return Pay(json);
        }

        public string GetPayParams(PaymentParam param)
        {
            var total = param.Total.ToString("N");
            var currency = Enum.GetName(typeof(PaypalCurrency), param.Currency);
            var payParams = new
            {
                intent = "sale",
                redirect_urls = new
                {
                    return_url = param.ReturnUrl,
                    cancel_url = param.CancelUrl,
                },
                payer = new
                {
                    payment_method = "paypal"
                },
                transactions = new dynamic[]
                {
                    new
                    {
                        amount = new
                        {
                            total = total,
                            currency = currency
                        },
                        description = param.Description,
                        custom = param.Code,
                        item_list = new
                        {
                            items = new dynamic[]
                            {
                                new
                                {
                                    name = param.Name,
                                    //description = param.Name,
                                    quantity = "1",
                                    price = total,
                                    //tax = "0.01",
                                    //sku = "1",
                                    currency = currency
                                }
                            }
                        }
                    }
                }
            };
            var json = new JavaScriptSerializer().Serialize(payParams);
            return json;
        }

        public string GetFullPayParams(decimal total, PaypalCurrency currency, string returnUrl, string cancelUrl)
        {
            var payParams = new
            {
                intent = "sale",
                redirect_urls = new
                {
                    return_url = returnUrl,
                    cancel_url = cancelUrl,
                },
                payer = new
                {
                    payment_method = "paypal"
                },
                transactions = new dynamic[]
                {
                    new
                    {
                        amount = new
                        {
                            total = total.ToString("N"),
                            currency = Enum.GetName(typeof(PaypalCurrency),currency),
                            details = new
                            {
                                subtotal = "30.00",
                                tax = "0.07",
                                shipping = "0.03",
                                handling_fee = "1.00",
                                shipping_discount = "-1.00",
                                insurance = "0.01"
                            }
                        },
                        description = "",
                        custom = "EBAY_EMS_90048630024435",
                        invoice_number = "48787589673",
                        payment_options = new
                        {
                            allowed_payment_method = "INSTANT_FUNDING_SOURCE"
                        },
                        soft_descriptor = "ECHI5786786",
                        item_list = new
                        {
                            items = new dynamic[]
                            {
                                new
                                {
                                    name = "hat",
                                    description = "Brown hat.",
                                    quantity = "5",
                                    price = "3",
                                    tax = "0.01",
                                    sku = "1",
                                    currency = "USD"
                                }
                            },
                            shipping_address = new
                            {
                                recipient_name = "Brian Robinson",
                                line1 = "4th Floor",
                                line2 = "Unit #34",
                                city = "San Jose",
                                country_code = "US",
                                postal_code = "95131",
                                phone = "011862212345678",
                                state = "CA"
                            },
                        }
                    }
                }
            };
            var json = new JavaScriptSerializer().Serialize(payParams);
            return json;
        }
    }
}