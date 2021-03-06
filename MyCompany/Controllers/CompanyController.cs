﻿using System.Web.Mvc;

namespace MyCompany.Controllers
{
    public class CompanyController : Controller
    {

        //public CompanyController()
        //{
        //}

        // GET: Company
        public ActionResult Index()
        {
            return View("CompanyHome");
        }

        // GET: Company/About 
        public ActionResult About()
        {
            return View("About");
        }

        // GET: Company/Contact
        public ActionResult Contact()
        {
            return View("Contact");
        }

        // GET: Company/News
        public ActionResult News()
        {
            return View("News");
        }

        // GET: Company/Privacy
        public ActionResult Privacy()
        {
            return View("Privacy");
        }

        // GET: Company/Forum
        public ActionResult Forum()
        {
            return View("Forum");
        }
    }
}