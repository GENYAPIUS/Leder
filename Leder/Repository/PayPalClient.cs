using System;
using PayPalCheckoutSdk.Core;
using BraintreeHttp;

using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;
using PayPalCheckoutSdk.Orders;
using System.Threading.Tasks;

namespace Leder.Repository
{
    public class PayPalClient
    {
        /**
            使用沙箱憑據設置PayPal環境。
             在生產中，請使用LiveEnvironment。
         */
        public static PayPalEnvironment environment()
        {
            return new SandboxEnvironment("AUaiHPKubOvW2WEVoToVgaTDf0XU6g8E3cb0pICGF1Y1tbDlzb6WKnenjVcUVPAV0opf7bk6dbXpHM_M", "EIUAMPb3Su0GZ6as0IrWcyw2aoScCDE10MyW8cr-usXLD8X7Si56vj3nlSE9TniK-Gs4FIIHwkvQbx3Q");
        }

        /**
           返回PayPalHttpClient實例以調用PayPal API。
         */
        public static HttpClient client()
        {
            return new PayPalHttpClient(environment());
        }

        public static HttpClient client(string refreshToken)
        {
            return new PayPalHttpClient(environment(), refreshToken);
        }

        /**
           使用此方法將Object序列化為JSON字符串。
        */
        public static String ObjectToJSONString(Object serializableObject)
        {
            MemoryStream memoryStream = new MemoryStream();
            var writer = JsonReaderWriterFactory.CreateJsonWriter(
                        memoryStream, Encoding.UTF8, true, true, "  ");
            DataContractJsonSerializer ser = new DataContractJsonSerializer(serializableObject.GetType(), new DataContractJsonSerializerSettings{UseSimpleDictionaryFormat = true});
            ser.WriteObject(writer, serializableObject);
            memoryStream.Position = 0;
            StreamReader sr = new StreamReader(memoryStream);
            return sr.ReadToEnd();
        }
    }

    public class GetOrderSample
    {

        //2. Set up your server to receive a call from the client
        /*
          You can use this method to retrieve an order by passing the order ID.
         */
        public async static Task<HttpResponse> GetOrder(string orderId, bool debug = false)
        {
            OrdersGetRequest request = new OrdersGetRequest(orderId);
            //3. Call PayPal to get the transaction
            var response = await PayPalClient.client().Execute(request);
            //4. Save the transaction in your database. Implement logic to save transaction to your database for future reference.
            var result = response.Result<Order>();
            Console.WriteLine("Retrieved Order Status");
            Console.WriteLine("Status: {0}", result.Status);
            Console.WriteLine("Order Id: {0}", result.Id);
            Console.WriteLine("Intent: {0}", result.Intent);
            Console.WriteLine("Links:");
            foreach (LinkDescription link in result.Links)
            {
                Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
            }
            AmountWithBreakdown amount = result.PurchaseUnits[0].Amount;
            Console.WriteLine("Total Amount: {0} {1}", amount.CurrencyCode, amount.Value);

            return response;
        }

        /*
          This driver method invokes the getOrder function with
          order ID to retrieve order details.

          To get the correct order ID, this sample uses createOrder to create
          a new order and then uses the newly-created order ID with GetOrder.
         */
        static void Main(string[] args)
        {
            GetOrder("REPLACE-WITH-VALID-ORDER-ID").Wait();
        }
    }
}