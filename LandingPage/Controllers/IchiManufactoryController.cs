using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LandingPage.Controllers
{
    public class IchiManufactoryController : Controller
    {
        private IConfiguration Configuration;

        public IchiManufactoryController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewBag.Title = Configuration["SeoConfig:Manufactory:Title"];
            ViewBag.KeyWords = Configuration["SeoConfig:Manufactory:KeyWords"];
            ViewBag.Descriptions = Configuration["SeoConfig:Manufactory:Description"];
            return View();
        }
    }
}
