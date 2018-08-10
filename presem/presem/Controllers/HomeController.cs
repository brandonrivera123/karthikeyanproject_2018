using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using presem.Models;

namespace presem.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Opportunities");
        }

        [HttpGet]
        public ViewResult EditForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult BogusForm()
        {
            return View();
        }
       
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
