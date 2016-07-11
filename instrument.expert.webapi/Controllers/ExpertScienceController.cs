using System.Net;
using System.Net.Http;
using System.Web.Http;
using instrument.expert.bll;
using instrument.expert.dto;

namespace instrument.expert.webapi.Controllers
{
    public class ExpertScienceController : ApiController
    {
        private readonly IExpertScienceBll _bll;

        public ExpertScienceController(IExpertScienceBll bll)
        {
            _bll = bll;
        }

        public HttpResponseMessage Post([FromBody] EXP_ExpertScienceDto value)
        {
            if (ModelState.IsValid)
            {
                var val = _bll.Insert(value);
                return Request.CreateResponse(HttpStatusCode.OK, val);
            }
            return Request.CreateResponse(HttpStatusCode.ExpectationFailed, "请求参数不合法！");
        }

        [HttpGet]
        public HttpResponseMessage Check(string id)
        {
            var value = _bll.Exist(id);
            var result = Request.CreateResponse(HttpStatusCode.OK, value);
            return result;
        }
    }
}