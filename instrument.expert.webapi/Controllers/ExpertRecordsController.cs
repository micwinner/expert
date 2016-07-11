using System.Net;
using System.Net.Http;
using System.Web.Http;
using instrument.expert.bll;
using instrument.expert.dto;

namespace instrument.expert.webapi.Controllers
{
    public class ExpertRecordsController : ApiController
    {
        private readonly IExpertRecordsBll _expertRecordsBll;

        public ExpertRecordsController(IExpertRecordsBll expertRecordsBll)
        {
            _expertRecordsBll = expertRecordsBll;
        }

        [HttpGet]
        public HttpResponseMessage Records(int id)
        {
            var result = _expertRecordsBll.GetOne(id);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpPut]
        public HttpResponseMessage Put([FromBody] EXP_RecordsDto model)
        {
            var result = _expertRecordsBll.Update(model);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody] EXP_RecordsDto model)
        {
            var result = _expertRecordsBll.Add(model);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            var result = _expertRecordsBll.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpGet]
        public HttpResponseMessage Records(int page, int pagesize)
        {
            int count;
            var list = _expertRecordsBll.GetList(page, pagesize, out count);
            var result = new EXP_RecordsResultDto {List = list, Count = count};
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpGet]
        public HttpResponseMessage Records(string id, int page, int pagesize)
        {
            int count;
            var list = _expertRecordsBll.GetListByEID(id, page, pagesize, out count);
            var result = new EXP_RecordsResultDto {List = list, Count = count};
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}