using System.Net;
using System.Net.Http;
using System.Web.Http;
using instrument.expert.bll;

namespace instrument.expert.webapi.Controllers
{
    public class SampleController : ApiController
    {
        private readonly ISampleBll _bll;

        public SampleController(ISampleBll bll)
        {
            _bll = bll;
        }

        public HttpResponseMessage GetSampleList()
        {
            var list = _bll.GetList();
            return Request.CreateResponse(HttpStatusCode.OK, list);
        }
    }
}