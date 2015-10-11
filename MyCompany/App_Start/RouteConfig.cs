using System.Web.Mvc;
using System.Web.Routing;


namespace MyCompany
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {


            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{controller}/{resource}.ashx/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Company", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "MyCompany.Controllers" }
            );
        }
    }
}
