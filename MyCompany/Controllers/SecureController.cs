using System.Web.Mvc;

namespace MyCompany.Controllers
{
    
    [RequireHttps]
    public class SecureController : Controller
    {
        // GET: Secure
        public ActionResult Index()
        {
            Session["Workaround"] = 0;
            return View("SecureIndex");
        }

        public ActionResult SecureIndex()
        {
            Session["Workaround"] = 0;
            return View("SecureIndex");
        }

    }
}