using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using System.Web.Configuration;
using instrument.expert.dto;
using Newtonsoft.Json;

namespace instrument.expert.web.Helpers
{
    public enum RequestDataType
    {
        Text,
        Stream
    }

    public class NetHelper
    {
        private static HttpContent ModelToStreamContent(object model)
        {
            var serializer = new DataContractJsonSerializer(model.GetType());
            var ms = new MemoryStream();
            serializer.WriteObject(ms, model);
            ms.Position = 0;
            HttpContent content = new StreamContent(ms);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return content;
        }

        private static HttpContent ModelToTextContent(object model)
        {
            var content = new StringContent(JsonConvert.SerializeObject(model));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return content;
        }

        /// <summary>
        ///     Http Get Action
        /// </summary>
        /// <param name="url">api地址</param>
        /// <param name="isNeedAuth">是否添加授权信息</param>
        /// <returns></returns>
        public static Task<HttpResponseMessage> HttpGet(string url, bool isNeedAuth)
        {
            var httpClient = new HttpClient();
            if (isNeedAuth)
            {
                var user = JsonConvert.DeserializeObject<TokenDto>(FormAuthHelper.GetCookie());
                var handler = new HttpClientHandler {UseCookies = true};
                var domain = WebConfigurationManager.AppSettings["domain"];
                handler.CookieContainer.Add(new Cookie(user.CookieName, user.TokenData, "/", domain));
                httpClient = new HttpClient(handler);
            }
            var result = httpClient.GetAsync(url);
            return result;
        }

        /// <summary>
        ///     Http Post Action
        /// </summary>
        /// <param name="url">api 地址</param>
        /// <param name="model">model</param>
        /// <param name="isNeedAuth">是否添加授权信息</param>
        /// <param name="dataType">请求方式： Text, Stream</param>
        /// <returns></returns>
        public static Task<HttpResponseMessage> HttpPost(string url, object model, bool isNeedAuth,
            RequestDataType dataType)
        {
            var httpClient = new HttpClient();
            if (isNeedAuth)
            {
                var user = JsonConvert.DeserializeObject<TokenDto>(FormAuthHelper.GetCookie());
                var handler = new HttpClientHandler {UseCookies = true};
                var domain = WebConfigurationManager.AppSettings["domain"];
                handler.CookieContainer.Add(new Cookie(user.CookieName, user.TokenData, "/", domain));
                httpClient = new HttpClient(handler);
            }
            HttpContent content;
            switch (dataType)
            {
                case RequestDataType.Stream:
                    content = ModelToStreamContent(model);
                    break;
                case RequestDataType.Text:
                    content = ModelToTextContent(model);
                    break;
                default:
                    content = ModelToStreamContent(model);
                    break;
            }
            return httpClient.PostAsync(url, content);
        }

        /// <summary>
        ///     Http Put Action
        /// </summary>
        /// <param name="url">api 地址</param>
        /// <param name="model">model</param>
        /// <param name="isNeedAuth">是否添加授权信息</param>
        /// <param name="dataType">请求方式： Text, Stream</param>
        /// <returns></returns>
        public static Task<HttpResponseMessage> HttpPut(string url, object model, bool isNeedAuth,
            RequestDataType dataType)
        {
            var httpClient = new HttpClient();
            if (isNeedAuth)
            {
                var user = JsonConvert.DeserializeObject<TokenDto>(FormAuthHelper.GetCookie());
                var handler = new HttpClientHandler {UseCookies = true};
                var domain = WebConfigurationManager.AppSettings["domain"];
                handler.CookieContainer.Add(new Cookie(user.CookieName, user.TokenData, "/", domain));
                httpClient = new HttpClient(handler);
            }
            HttpContent content;
            switch (dataType)
            {
                case RequestDataType.Stream:
                    content = ModelToStreamContent(model);
                    break;
                case RequestDataType.Text:
                    content = ModelToTextContent(model);
                    break;
                default:
                    content = ModelToStreamContent(model);
                    break;
            }
            return httpClient.PutAsync(url, content);
        }

        /// <summary>
        ///     Http Delete Action
        /// </summary>
        /// <param name="url">api 地址</param>
        /// <param name="isNeedAuth">是否添加授权信息</param>
        /// <returns></returns>
        public static Task<HttpResponseMessage> HttpDelete(string url, bool isNeedAuth)
        {
            var httpClient = new HttpClient();
            if (isNeedAuth)
            {
                var user = JsonConvert.DeserializeObject<TokenDto>(FormAuthHelper.GetCookie());
                var handler = new HttpClientHandler {UseCookies = true};
                var domain = WebConfigurationManager.AppSettings["domain"];
                handler.CookieContainer.Add(new Cookie(user.CookieName, user.TokenData, "/", domain));
                httpClient = new HttpClient(handler);
            }
            var result = httpClient.DeleteAsync(url);
            return result;
        }
    }
}