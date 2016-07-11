using System.Net;
using System.Net.Http;
using System.Web.Http;
using instrument.expert.bll;

namespace instrument.expert.webapi.Controllers
{
    public class IMSortController : ApiController
    {
        private readonly IIMSortBll _bll;

        public IMSortController(IIMSortBll bll)
        {
            _bll = bll;
        }

        //[LoginRequired]
        public HttpResponseMessage GetListByMID([FromUri] string id)
        {
            if (string.IsNullOrEmpty(id))
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var list = _bll.GetListByMID(id);
            var reponse = Request.CreateResponse(HttpStatusCode.OK, list);
            return reponse;
        }
    }
}