using System.Web.Mvc;
using instrument.expert.web.Helpers;

namespace instrument.expert.web.Controllers
{
    public class StatisticsController : Controller
    {
        [AuthCheck]
        public ActionResult Index()
        {
            return View();
        }
    }
}