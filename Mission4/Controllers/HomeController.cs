using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext Context { get; set; }
        public HomeController(MovieContext Temp)
        {
            Context = Temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcast()
        {
            return View("MyPodcast");
        }
        [HttpGet]
        public IActionResult MovieInfo()
        {
            return View("MovieInfo");
        }
        [HttpPost]
        public IActionResult MovieInfo(MovieInfo ar)
        {
            if (ModelState.IsValid)
            {
                Context.Add(ar);
                Context.SaveChanges();

                return View("Confirmation", ar);
            }
            else
            {
                return View(ar);
            }
        }
    }
}
