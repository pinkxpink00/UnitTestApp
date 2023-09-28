using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UnitTestApp.Models;

namespace UnitTestApp.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            ViewData["Message"] = "Hello world!";
            return View("Index");
        }

     
    }
}