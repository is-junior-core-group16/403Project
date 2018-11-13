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
        public static int assignid = 0;
        public static Requests edit = new Requests();

        // GET: User
        //[Authorize]
        public ActionResult ShowList()
        {
            return View(requests);
        }
        //[Authorize]
        public ActionResult Submit()
        {
            return View();
        }
        //[Authorize]
        public ActionResult SoftwareInput(Requests request)
        {


            request.SoftwareName = null;
            return View("SoftwareInput");
        }

        //[Authorize]
        public ActionResult Delete(int id)
        {
            requests.RemoveAll(item => item.RequestID == id);
            return View("ShowList", requests);
        }
       
        //[Authorize]
        public ActionResult Update(int id)
        {
            edit = requests.Find(item => item.RequestID == id);
            return View(edit);
        }

        [HttpPost]
        public ActionResult Update(Requests update)
        {
            requests.RemoveAll(item => item.RequestID == update.RequestID);
            requests.Add(update);
            return View("ShowList", requests);
        }


        [HttpPost]
        public ActionResult Submit(Requests request)
        {
            
            if (request.SoftwareName == "Other")
                {
                request.RequestID = assignid;
                assignid++;
                requests.Add(request);
                return View("SoftwareInput");
                }
            else if(request.userName == null)
                {
                request.userName = requests[requests.Count - 1].userName;
                request.managerName = requests[requests.Count - 1].managerName;
                request.softwareType = requests[requests.Count - 1].softwareType;
                requests.RemoveAt(requests.Count - 1);
                request.RequestID = assignid;
                assignid++;
                requests.Add(request);
                }
            else
                {
                request.RequestID = assignid;
                assignid++;
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
       
        


    }
}