﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403Project1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About";

            return View();
        }

        [HttpPost]
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us";

            return View("Contact");
        }
    }
}