using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Maple_Hub.Models;

namespace Maple_Hub.Controllers
{
    public class MapleHubController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public MapleHubController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Account()
        {
            return View();
        }
        
        public IActionResult Guides()
        {
            return View();
        }

        public IActionResult Forum()
        {
            return View();
        }

        public IActionResult Guide()
        {
            return View();
        }
        public IActionResult GuideSubmit()
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
