using System.Web.Http;

namespace instrument.expert.webapi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                "ExpertApi",
                "api/{controller}/{action}/{id}",
                new {id = RouteParameter.Optional}
                );
            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new {id = RouteParameter.Optional}
                );
        }
    }
}