﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SurveyOnline.WebSite.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Home Page.
        /// </summary>
        /// <returns>Home Page action view.</returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}