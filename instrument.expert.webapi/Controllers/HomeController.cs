using System.Web.Mvc;

namespace instrument.expert.webapi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}