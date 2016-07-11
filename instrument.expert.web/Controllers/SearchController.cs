using System.Web.Mvc;
using instrument.expert.dto;
using instrument.expert.web.Helpers;

namespace instrument.expert.web.Controllers
{
    public class SearchController : BaseController
    {
        [AuthCheck]
        public ActionResult Index()
        {
            return View();
        }

        [AuthCheck]
        public ActionResult Search(EXP_SearchWhereDto model)
        {
            return null;
        }
    }
}