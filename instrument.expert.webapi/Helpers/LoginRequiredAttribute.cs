using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace instrument.expert.webapi.Helpers
{
    public class LoginRequiredAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var token = WebConfigurationManager.AppSettings["CookieName"];
            if (actionContext.Request.Headers.Contains("Cookie")) //无cookie,自然无票据
            {
                var cookieHeaderValue = actionContext.Request.Headers.GetCookies().FirstOrDefault();
                if (null != cookieHeaderValue)
                {
                    var firstOrDefault = cookieHeaderValue.Cookies.FirstOrDefault(c => c.Name == token);
                    if (firstOrDefault != null)
                    {
                        var tokenString = firstOrDefault.Value;
                        if (string.IsNullOrEmpty(tokenString)) //票据为空
                            actionContext.Response =
                                actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "无权访问！");
                        using (var redis = new RedisHelper(true))
                        {
                            if (!redis.ExistsKey(tokenString)) //redis 过期
                                actionContext.Response =
                                    actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized,
                                        "访问密钥已经过期请重新登录！");
                            else
                            {
                                redis.UpdateExpire(tokenString);
                                base.OnActionExecuting(actionContext);
                            }
                        }
                    }
                    else
                    {
                        actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized,
                            "无权访问！");
                    }
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized,
                        "无权访问！");
                }
            }
            else
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "无权访问！");
            }
        }
    }
}