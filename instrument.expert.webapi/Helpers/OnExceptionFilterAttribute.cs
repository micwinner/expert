using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;

namespace instrument.expert.webapi.Helpers
{
    public class OnExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            LogHelper.WriteLog(
                actionExecutedContext.Exception.Message,
                actionExecutedContext.Exception,
                LogLevel.Fatal);
#if DEBUG
            actionExecutedContext.Response = actionExecutedContext.Request.CreateErrorResponse(
                HttpStatusCode.InternalServerError,
                actionExecutedContext.Exception.Message,
                actionExecutedContext.Exception);
#else
            actionExecutedContext.Response = actionExecutedContext.Request.CreateErrorResponse(
                HttpStatusCode.InternalServerError, 
                "发生严重错误，请联系相关技术人员");
#endif
        }
    }
}