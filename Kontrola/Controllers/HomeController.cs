﻿using Microsoft.AspNetCore.Mvc;
using Kontrola.Models;
using System.Diagnostics;

namespace Kontrola.Controllers
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
            ViewBag.OpcaoMenu = 1;
            return View();
        }

        public IActionResult QuemSomos()
        {
            ViewBag.OpcaoMenu = 4;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}