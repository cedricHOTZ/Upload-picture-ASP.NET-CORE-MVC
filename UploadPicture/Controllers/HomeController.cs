using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UploadPicture.Data;
using UploadPicture.Models;

namespace UploadPicture.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public readonly DefaultContext _context;

        public HomeController(ILogger<HomeController> logger, DefaultContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var items = _context.Movie.ToList();
            return View(items);
        }

        public IActionResult Create()
        {
            var items = _context.Movie.ToList();
            return View(items);
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
