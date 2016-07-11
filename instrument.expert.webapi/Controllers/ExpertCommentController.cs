using System.Net;
using System.Net.Http;
using System.Web.Http;
using instrument.expert.bll;
using instrument.expert.dto;

namespace instrument.expert.webapi.Controllers
{
    public class ExpertCommentController : ApiController
    {
        private readonly IExpertCommentBll _bll;

        public ExpertCommentController(IExpertCommentBll bll)
        {
            _bll = bll;
        }

        //[LoginRequired]
        [HttpGet]
        public HttpResponseMessage Check(string id)
        {
            var value = _bll.Exist(id);
            var result = Request.CreateResponse(HttpStatusCode.OK, value);
            return result;
        }

        //[LoginRequired]
        [HttpPost]
        public HttpResponseMessage Post([FromBody] EXP_CommentDto value)
        {
            if (ModelState.IsValid)
            {
                var val = _bll.Insert(value);
                return Request.CreateResponse(HttpStatusCode.OK, val);
            }
            return Request.CreateResponse(HttpStatusCode.ExpectationFailed, "请求参数不合法！");
        }
    }
}