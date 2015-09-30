using System.Web.Optimization;

namespace MyCompany
{
    public class BundleConfig
    {

        //<link rel = "stylesheet" href="css/grid.css">
        //<link rel = "stylesheet" href="css/camera.css" />
        //<link rel = "stylesheet" href="css/style.css">

        //<script src = "js/jquery.js" ></ script >
        //< script src="js/jquery-migrate-1.2.1.js"></script>
        //<script src = "js/jquery.equalheights.js" ></ script >
        //< script src="js/camera.js"></script>
        //<!--[if (gt IE 9)|!(IE)]><!-->
        //<script src = "js/jquery.mobile.customized.min.js" ></ script >
        //< script src="js/wow/wow.js"></script>

        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/js/jquery.js",
                        "~/js/jquery-migrate-1.2.1.js",
                        "~/js/jquery.equalheights.js",
                        "~/js/jquery.mobile.customized.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/camera").Include(
                        "~/js/camera.js"));

            bundles.Add(new ScriptBundle("~/bundles/wow").Include(
                        "~/js/wow/wow.js"));

            bundles.Add(new ScriptBundle("~/bundles/script").Include(
                        "~/js/script.js",
                        "~/js/modal.js",
                        "~/js/TMForm.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/site/css/grid.css",
                      "~/site/css/camera.css",
                      "~/site/css/contact-form.css",
                      "~/site/css/style.css"));

        }

    


    }
}