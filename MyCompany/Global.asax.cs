using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using System.Web.Optimization;

namespace MyCompany
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            //mjh
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new CompanyViewEngine());

            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }
    }
}