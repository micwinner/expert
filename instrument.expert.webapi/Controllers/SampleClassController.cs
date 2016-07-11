using System.Net;
using System.Net.Http;
using System.Web.Http;
using instrument.expert.bll;

namespace instrument.expert.webapi.Controllers
{
    public class SampleClassController : ApiController
    {
        private readonly ISampleClassBll _bll;

        public SampleClassController(ISampleClassBll bll)
        {
            _bll = bll;
        }

        public HttpResponseMessage GetSampleClsList(string id)
        {
            var list = _bll.GetSampleClsListByID(id);
            return Request.CreateResponse(HttpStatusCode.OK, list);
        }
    }
}