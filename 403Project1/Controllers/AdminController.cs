using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403Project1.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        public ActionResult Index()
        {
            return View("Index.cshtml");
        }

        //admin view to simply see the requests, use page that Kyle created (question for Kyle: how do I use list to show all requests?)
        public ActionResult ShowAllRequests()
        {
            return View("ShowList.cshtml");
        }

        //show the black list (hard coded, add to database for later)
        public ActionResult ShowBlackList()
        {
            return View("ShowBlackList.cshtml");
        }


        //show the white list (hard coded, add to database for later)
        public ActionResult ShowWhiteList()
        {
            return View("ShowWhiteList.cshtml");
        }
    }
}