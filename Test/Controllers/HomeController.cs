using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Test.Models;

namespace Test.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult Create()
        {
            var model = new ProductCreateModel();

            return View(model);
        }
        public IActionResult Edit()
        {
            var model = new ProductEditModel();
            return View(model);
        }
        public IActionResult Edit1()
        {
            var model = new ProductEditModel();
            return View(model);
        }
        //[HttpPost]
        //public IActionResult Create(ProductEditModel model)
        //{
        //    string message = string.Empty;
        //    if (ModelState.IsValid)
        //    {
        //        message = "Product:" + model.Name + "Rate" + model.Note + "Note" +
                   
        //            "Create success";
        //    }
        //    else {
        //        message = "failed. try angain";
        //            }
        
        //    return Content(message);
        //}
    }
}

