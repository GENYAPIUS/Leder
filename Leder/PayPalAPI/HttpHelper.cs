using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Leder.PayPalAPI
{
    public class HttpHelper
    {
        public static string PostForm(string url, string userName, string password, Dictionary<string, object> dic, Encoding encoding)
        {
            var param = string.Empty;
            foreach (var o in dic)
            {
                if (string.IsNullOrEmpty(param))
                    param += o.Key + "=" + o.Value;
                else
                    param += "&" + o.Key + "=" + o.Value;
            }
            byte[] byteArray = encoding.GetBytes(param);

            //处理HttpWebRequest访问https有安全证书的问题（ 请求被中止: 未能创建 SSL/TLS 安全通道。）
            ServicePointManager.ServerCertificateValidationCallback += (s, cert, chain, sslPolicyErrors) => true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(encoding.GetBytes(userName + ":" + password)));
            request.PreAuthenticate = true;

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;

            //写入参数
            Stream newStream = request.GetRequestStream();
            newStream.Write(byteArray, 0, byteArray.Length);
            newStream.Close();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    if (stream != null)
                        using (StreamReader sr = new StreamReader(stream, Encoding.UTF8))
                        {
                            return sr.ReadToEnd();
                        }
                }
            }
            return string.Empty;
        }

        public static string PostJson(string url, string userName, string password, string json, Encoding encoding)
        {
            byte[] byteArray = encoding.GetBytes(json);

            //处理HttpWebRequest访问https有安全证书的问题（ 请求被中止: 未能创建 SSL/TLS 安全通道。）
            ServicePointManager.ServerCertificateValidationCallback += (s, cert, chain, sslPolicyErrors) => true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 |
                                                    SecurityProtocolType.Tls;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(encoding.GetBytes(userName + ":" + password)));
            request.PreAuthenticate = true;

            request.Method = "POST";
            request.Headers.Add("Cache-Control", "no-cache");
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;

            //写入参数
            Stream newStream = request.GetRequestStream();
            newStream.Write(byteArray, 0, byteArray.Length);
            newStream.Close();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    if (stream != null)
                        using (StreamReader sr = new StreamReader(stream, Encoding.UTF8))
                        {
                            return sr.ReadToEnd();
                        }
                }
            }
            return string.Empty;
        }

        public static string Get(string url, string userName, string password, Encoding encoding)
        {
            //处理HttpWebRequest访问https有安全证书的问题（ 请求被中止: 未能创建 SSL/TLS 安全通道。）
            ServicePointManager.ServerCertificateValidationCallback += (s, cert, chain, sslPolicyErrors) => true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 |
                                                    SecurityProtocolType.Tls;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(encoding.GetBytes(userName + ":" + password)));
            request.PreAuthenticate = true;

            request.Method = "GET";
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    if (stream != null)
                        using (StreamReader sr = new StreamReader(stream, Encoding.UTF8))
                        {
                            return sr.ReadToEnd();
                        }
                }
            }
            return string.Empty;
        }
    }
}