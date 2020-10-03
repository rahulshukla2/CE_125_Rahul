using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using core_lab8_1.Models;

namespace core_lab8_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult test1()
        {
            int x = 5;
            int y = 10;
            ViewBag.num1 = x;
            ViewBag.num2 = y;
            ViewBag.ans = x + y;
            
            return View();
        }
        [HttpGet]
        public IActionResult test2()
        {

            return View();
        }

        
        [HttpPost]
        public IActionResult test2(string num1,string num2)
        {
            ViewBag.ans = Convert.ToInt32(num1) + Convert.ToInt32(num2);
            return View();
        }
        [HttpGet]
        public IActionResult user_registration()
        {

            return View();
        }

         [HttpPost]
         public IActionResult user_registration(string fname, string lname, string con, string email, string city, string state)
         {
            ViewBag.fname = fname;
            ViewBag.lname = lname;
            ViewBag.con = con;
            ViewBag.email = email;
            ViewBag.city = city;
            ViewBag.state = state;

            return View();
         }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
