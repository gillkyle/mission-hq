﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionSite.Controllers
{
    public class MissionController : Controller
    {
        // GET: Mission
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        { 
            return View();
        }

        public ActionResult FAQ(string junk, string name)
        {
            ViewBag.missionName = name;
            return View();
        }
    }
}