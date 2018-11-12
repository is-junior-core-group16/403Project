using _403Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403Project1.Controllers
{
    public class UserController : Controller
    {
        public static List<Requests> requests = new List<Requests>();
        public static List<String> Whitelist = new List<String>();
        public static List<String> Blacklist = new List<String>();

        // GET: User
        [Authorize]
        public ActionResult ShowList()
        {
            return View(requests);
        }
        [Authorize]
        public ActionResult Submit()
        {
            return View();
        }
        [Authorize]
        public ActionResult SoftwareInput(Requests request)
        {


            request.SoftwareName = null;
            return View("SoftwareInput");
        }


       

        [HttpPost]
        public ActionResult Submit(Requests request)
        {
            
            if (request.SoftwareName == "Other")
                {
                requests.Add(request);
                return View("SoftwareInput");
                }
            else if(request.userName == null)
                {
                request.userName = requests[requests.Count - 1].userName;
                request.managerName = requests[requests.Count - 1].managerName;
                request.softwareType = requests[requests.Count - 1].softwareType;
                requests.RemoveAt(requests.Count - 1);
                requests.Add(request);
                }
            else
                {
                    requests.Add(request);
                }

            if(ModelState.IsValid || (requests[requests.Count - 1].managerName != null && requests[requests.Count - 1].userName != null && requests[requests.Count - 1].SoftwareName != null))
                {
                if (Whitelist.Count == 0)
                {
                    Whitelist.Add("KiTTY");
                    Whitelist.Add("NuGet");
                }

                if (Blacklist.Count == 0)
                {
                    Blacklist.Add("Virus");
                    Blacklist.Add("SpaceSniffer");
                }

                foreach (string item in Whitelist)
                {
                    if (item.Contains(requests[requests.Count - 1].SoftwareName))
                    {
                        requests.RemoveAt(requests.Count - 1);
                        return View("Accepted");
                    }
                }

                foreach(string item in Blacklist)
                {
                    if (item.Contains(requests[requests.Count - 1].SoftwareName))
                    {
                        requests.RemoveAt(requests.Count - 1);
                        return View("Rejected");
                    }
                }

                return View("Thanks", requests[requests.Count - 1]);
                }
            else
                {
                    return View();
                }
            
            
        }
        //Write a delete function,
        //and try to figure out why the SoftwareInput page always says options..

       
    }
}