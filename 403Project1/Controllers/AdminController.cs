using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _403Project1.Models;

namespace _403Project1.Controllers
{
    public class AdminController : Controller
    {
        public static List<Requests> requests = new List<Requests>();
        public static Requests myreq = new Requests();
        public static List<String> Whitelist = new List<String>();
        public static List<String> Blacklist = new List<String>();

        // GET: Admin
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        //admin view to simply see the requests, use page that Kyle created (question for Kyle: how do I use list to show all requests?)
        [Authorize]
        public ActionResult ShowList()
        {
            return View();
        }

        //show the black list (hard coded, add to database for later)
        [Authorize]
        public ActionResult ShowBlackList()
        {
            return View();
        }

        [Authorize]
        //show the white list (hard coded, add to database for later)
        public ActionResult ShowWhiteList()
        {
            return View();
        }
    }
}