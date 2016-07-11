using System.Net;
using System.Net.Http;
using System.Web.Http;
using instrument.expert.bll;

namespace instrument.expert.webapi.Controllers
{
    public class IMSortClassController : ApiController
    {
        private readonly IIMSortClassBll _bll;

        public IMSortClassController(IIMSortClassBll bll)
        {
            _bll = bll;
        }

        //[LoginRequired]
        public HttpResponseMessage GetCls3ListByID(string id)
        {
            var list = _bll.GetCls3ListByID(id);
            return Request.CreateResponse(HttpStatusCode.OK, list);
        }

        //[LoginRequired]
        public HttpResponseMessage GetCls3ListByID_Sql(string id)
        {
            var list = _bll.GetCls3ListByID_Sql(id);
            return Request.CreateResponse(HttpStatusCode.OK, list);
        }
    }
}