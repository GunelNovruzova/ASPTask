using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Intro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "Gunel";
            ViewData["SurName"] = "Novruzova";

            ViewBag.Name1 = "Chinara";
            ViewBag.SurName1 = "Ibadova";
            TempData["Name"]="Farah";
            TempData["SurName"] = "Ibrahimli";
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
