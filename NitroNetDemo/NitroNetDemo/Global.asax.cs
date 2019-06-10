using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using NitroNet.Mvc;

namespace NitroNetDemo
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
           //  FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
           // BundleConfig.RegisterBundles(BundleTable.Bundles);

            ViewEngines.Engines.Add(DependencyResolver.Current.GetService<NitroNetViewEngine>());
        }
    }
}
