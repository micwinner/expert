using System.Net;
using System.Net.Http;
using System.Web.Http;
using instrument.expert.bll;

namespace instrument.expert.webapi.Controllers
{
    public class VIPZoneCountryController : ApiController
    {
        private readonly IVIPZoneCountryBll _bll;

        public VIPZoneCountryController(IVIPZoneCountryBll bll)
        {
            _bll = bll;
        }

        //[LoginRequired]
        public HttpResponseMessage Get()
        {
            var value = _bll.GetAllCountry();
            return Request.CreateResponse(HttpStatusCode.OK, value);
        }
    }
}