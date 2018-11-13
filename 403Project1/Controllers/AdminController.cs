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

        //Get:Home
        public static List<AllRequests> listRequests = new List<AllRequests>();
        public static AllRequests edit = new AllRequests();
        public static AllRequests listitem1 = new AllRequests();

        [Authorize]
        public ActionResult Index()

        {
            return View();
        }

        [Authorize]
        public ActionResult LandingPage()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Index(AllRequests myRequest)
        {

            myRequest.RequestID = (myRequest.Name.Substring(0, 2) + listRequests.Count().ToString());
            listRequests.Add(myRequest);
            return View("Thanks");
        }

        [Authorize]
        public ActionResult DisplayRequests()
        {
            if (!listRequests.Exists(item => item.RequestID == "5A"))
            {
                listitem1.Name = "Kyle Harrison";
                listitem1.RequestID = "5A";
                listitem1.SoftwareRequest = "Kitty++";
                listitem1.SoftwareType = "Operating System";
                listitem1.ListType = "Black List";
                listRequests.Add(listitem1);
            }

            return View(listRequests);
        }

        [Authorize]
        public ActionResult Delete(string id)
        {
            listRequests.RemoveAll(item => item.RequestID == id);
            return View("DisplayRequests", listRequests);
        }

        [Authorize]
        public ActionResult Edit(string id)
        {
            edit = listRequests.Find(item => item.RequestID == id);
            return View("Edit", edit);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Edit(AllRequests update)
        {
            listRequests.RemoveAll(item => item.RequestID == update.RequestID);
            listRequests.Add(update);
            return View("DisplayRequests", listRequests);
        }


        //show the black list (hard coded, add to database for later)
        [Authorize]
        public ActionResult ShowBlackList()
        {
            return View();
        }


        //show the white list (hard coded, add to database for later)
        [Authorize]
        public ActionResult ShowWhiteList()
        {
            return View();
        }



    }
}