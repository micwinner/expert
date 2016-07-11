using System.Web;
using System.Web.Mvc;

namespace instrument.expert.web.Helpers
{
    public class AuthCheckAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var Pass = false;
            if (!httpContext.Request.IsAuthenticated)
            {
                httpContext.Response.StatusCode = 401; //无权限状态码  
                Pass = false;
            }
            else
            {
                Pass = true;
            }
            return Pass;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            base.HandleUnauthorizedRequest(filterContext);
            if (filterContext.HttpContext.Response.StatusCode == 401)
            {
                filterContext.Result = new RedirectResult("/");
            }
        }
    }
}