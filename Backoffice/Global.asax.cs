using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Backoffice
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error()
        {
            Exception lastException = Server.GetLastError();
            NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
            logger.Error(lastException);

            //Response.RedirectToRoute(new { controller = "Error", action = "ErrorPage", id = UrlParameter.Optional });
        }
    }
}
