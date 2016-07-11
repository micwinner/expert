using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.WebApi;
//using HibernatingRhinos.Profiler.Appender.EntityFramework;
using instrument.expert.mapper;
using instrument.expert.webapi.Helpers;

namespace instrument.expert.webapi
{
    public class WebApiApplication : HttpApplication
    {
        private static void ConfigureApi(HttpConfiguration config)
        {
            config.Filters.Add(new OnExceptionFilterAttribute());
        }

        protected void Application_Start()
        {
#if DEBUG
            //EntityFrameworkProfiler.Initialize();
#endif
            BundleTable.EnableOptimizations = false;
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ConfigureApi(GlobalConfiguration.Configuration); //注册全局异常处理程序

            var config = GlobalConfiguration.Configuration;
            //config.Formatters.Clear();
            //config.Formatters.Add(new JsonMediaTypeFormatter());
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterAssemblyTypes(Assembly.Load("instrument.expert.repository")).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(Assembly.Load("instrument.expert.bll")).AsImplementedInterfaces();
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            AutoMapperConfig.Configuration();
            LogHelper.SetConfig();
        }
    }
}