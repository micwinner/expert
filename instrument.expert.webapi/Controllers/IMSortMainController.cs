using System.Net;
using System.Net.Http;
using System.Web.Http;
using instrument.expert.bll;

namespace instrument.expert.webapi.Controllers
{
    public class IMSortMainController : ApiController
    {
        private readonly IIMSortMainBll _bll;

        public IMSortMainController(IIMSortMainBll bll)
        {
            _bll = bll;
        }

        //[LoginRequired]
        public HttpResponseMessage Get()
        {
            var list = _bll.GetAllImSortMainDtos();
            var reponse = Request.CreateResponse(HttpStatusCode.OK, list);
            return reponse;
        }
    }
}