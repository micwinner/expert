using System.Net;
using System.Net.Http;
using System.Web.Http;
using instrument.expert.bll;

namespace instrument.expert.webapi.Controllers
{
    public class SampleSortController : ApiController
    {
        private readonly ISampleSortBll _bll;

        public SampleSortController(ISampleSortBll bll)
        {
            _bll = bll;
        }

        public HttpResponseMessage GetSampleSortList(string id)
        {
            var list = _bll.GetSampleSortListByID(id);
            return Request.CreateResponse(HttpStatusCode.OK, list);
        }
    }
}