using System.Net;
using System.Net.Http;
using System.Web.Http;
using instrument.expert.bll;

namespace instrument.expert.webapi.Controllers
{
    public class VIPZoneCityController : ApiController
    {
        private readonly IVIPZoneCityBll _bll;

        public VIPZoneCityController(IVIPZoneCityBll bll)
        {
            _bll = bll;
        }

        //[LoginRequired]
        public HttpResponseMessage GetListByPid(int id)
        {
            var value = _bll.GetCityListByID(id);
            return Request.CreateResponse(HttpStatusCode.OK, value);
        }
    }
}