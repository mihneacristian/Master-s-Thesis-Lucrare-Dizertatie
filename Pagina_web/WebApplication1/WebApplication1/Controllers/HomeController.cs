using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Istoric()
        {
            ViewData["Message"] = "";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Evolutie_cladiri()
        {
            ViewData["Message"] = "";

            return View();
        }
        public IActionResult Sibiul_astazi()
        {
            ViewData["Message"] = "";

            return View();
        }
        public IActionResult Sibiul_istoric()
        {
            ViewData["Message"] = "";

            return View();
        }
        public IActionResult Catedrala_Evanghelica()
        {
            ViewData["Message"] = "";

            return View();
        }
        public IActionResult Sistemul_de_Fortificatii()
        {
            ViewData["Message"] = "";

            return View();
        }
        public IActionResult Introducere()
        {
            ViewData["Message"] = "Aplicație WebGIS pentru promovarea istoriei și patrimoniului orașului Sibiu";

            return View();
        }
        public IActionResult Camera_live()
        {
            ViewData["Message"] = "";

            return View();
        }
        public IActionResult Camera_live_2()
        {
            ViewData["Message"] = "";
        
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
