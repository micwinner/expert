using System.Net;
using System.Net.Http;
using System.Web.Http;
using instrument.expert.bll;
using instrument.expert.dto;

namespace instrument.expert.webapi.Controllers
{
    public class ExpertController : ApiController
    {
        private readonly IExpertBll _bll;

        public ExpertController(IExpertBll bll)
        {
            _bll = bll;
        }

        //[LoginRequired]
        public HttpResponseMessage Get()
        {
            var value = _bll.GetList();
            var result = Request.CreateResponse(HttpStatusCode.OK, value);
            return result;
        }

        //[LoginRequired]
        public HttpResponseMessage Get(int id)
        {
            var value = _bll.GetByID(id);
            var result = Request.CreateResponse(HttpStatusCode.OK, value);
            return result;
        }

        [HttpGet]
        public HttpResponseMessage Check(string id)
        {
            var value = _bll.Exist(id);
            var result = Request.CreateResponse(HttpStatusCode.OK, value);
            return result;
        }

        [HttpPost]
        public HttpResponseMessage InsertExpert([FromBody] EXP_ExpertDto model)
        {
            if (ModelState.IsValid)
            {
                var val = _bll.Insert(model);
                return Request.CreateResponse(HttpStatusCode.OK, val);
            }
            return Request.CreateResponse(HttpStatusCode.ExpectationFailed, "请求参数不合法！");
        }

        public HttpResponseMessage Experts([FromBody] EXP_SearchWhereDto model)
        {
            var val = _bll.GetSearch(model);
            return Request.CreateResponse(HttpStatusCode.OK, val);
        }

        public void Put(int id, [FromBody] string value)
        {
        }

        public void Delete(int id)
        {
        }
    }
}