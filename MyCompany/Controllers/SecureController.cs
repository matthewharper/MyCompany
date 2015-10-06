using System.Web.Mvc;

namespace MyCompany.Controllers
{
    
    public class SecureController : Controller
    {
        // GET: Secure
        public ActionResult Index()
        {
            return View("SecureIndex");
        }

        public ActionResult SecureIndex()
        {
            return View("SecureIndex");
        }

    }
}