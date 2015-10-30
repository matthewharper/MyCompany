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
            //mjh -- Custom view engine is required to move default view locations within the site structure.
            //      MVC doesn't have to look in the default /view folders, etc.
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new CompanyViewEngine());

            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            
            //mjh -- Uncomment the line below to debug your MVC routing.  Downloaded this tool from a developer site.
            //       I forgot where, or I would have given him props here.
            //RouteDebug.RouteDebugger.RewriteRoutesForTesting(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

           
        }

        
    }
}