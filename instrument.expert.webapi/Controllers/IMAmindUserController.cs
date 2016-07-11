using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using instrument.expert.bll;
using instrument.expert.dto;
using instrument.expert.webapi.Helpers;

namespace instrument.expert.webapi.Controllers
{
    public class IMAmindUserController : ApiController
    {
        private readonly IIMAdminUserBll _bll;
        private readonly RedisHelper redis = new RedisHelper(true);
        private readonly TokenHelper token = new TokenHelper();

        public IMAmindUserController(IIMAdminUserBll bll)
        {
            _bll = bll;
        }

        public HttpResponseMessage Post([FromBody] IM_AdminUserDto dto)
        {
            if (null == dto) return Request.CreateErrorResponse(HttpStatusCode.NotFound, new Exception("请求数据为空！"));
            var model = _bll.Login(dto.admin_name, dto.admin_password);
            if (null == model) return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, new Exception("用户不合法！"));
            model.admin_password = ""; //密码不可见
            var tokenString = token.CreateToken();
            var data = new TokenDto
            {
                AdminUser = model,
                CookieExprise = int.Parse(ConfigurationManager.AppSettings["CookieExprise"]),
                CookieName = ConfigurationManager.AppSettings["CookieName"],
                TokenData = tokenString
            };
            var result = redis.Set(tokenString, model);
            redis.Dispose();
            return result
                ? Request.CreateResponse(HttpStatusCode.OK, data)
                : Request.CreateErrorResponse(HttpStatusCode.ServiceUnavailable, "凭证存储失败！");
        }
    }
}