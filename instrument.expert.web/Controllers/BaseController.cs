using System.Web.Mvc;
using instrument.expert.web.Helpers;

namespace instrument.expert.web.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnException(ExceptionContext filterContext)
        {
            if (filterContext.ExceptionHandled) return;
            LogHelper.WriteLog(
                filterContext.Exception.Message,
                filterContext.Exception,
                LogLevel.Fatal);
            filterContext.Result = new RedirectResult("/Home/Index");
            filterContext.ExceptionHandled = true;
        }
    }
}