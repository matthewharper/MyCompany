using System.Web.Mvc;

namespace MyCompany
{
    public class CompanyViewEngine : RazorViewEngine
    {
        public CompanyViewEngine()
        {
            var viewLocations = new[] {
            "~/Views/{1}/{0}.cshtml",
            "~/Views/Shared/{0}.cshtml",
            "~/site/Views/Shared/{0}.cshtml",
            "~/site/Views/{1}/{0}.cshtml",
            "~/site/Views/{0}.cshtml"
        };

            this.PartialViewLocationFormats = viewLocations;
            this.ViewLocationFormats = viewLocations;
        }
    }
}