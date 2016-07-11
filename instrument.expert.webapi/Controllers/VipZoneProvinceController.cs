using System.Net;
using System.Net.Http;
using System.Web.Http;
using instrument.expert.bll;

namespace instrument.expert.webapi.Controllers
{
    public class VipZoneProvinceController : ApiController
    {
        private readonly IVIPZoneProvinceBll _bll;

        public VipZoneProvinceController(IVIPZoneProvinceBll bll)
        {
            _bll = bll;
        }

        //[LoginRequired]
        public HttpResponseMessage GetListByCid(int id)
        {
            var list = _bll.GetProvinceListByCountryID(id);
            return Request.CreateResponse(HttpStatusCode.OK, list);
        }
    }
}