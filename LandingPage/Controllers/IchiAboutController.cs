﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace LandingPage.Controllers
{
    public class IchiAboutController : Controller
    {
        private IConfiguration Configuration;

        public IchiAboutController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewBag.Title = Configuration["SeoConfig:About:Title"];
            ViewBag.KeyWords = Configuration["SeoConfig:About:KeyWords"];
            ViewBag.Descriptions = Configuration["SeoConfig:About:Description"];
            return View();
        }
    }
}
