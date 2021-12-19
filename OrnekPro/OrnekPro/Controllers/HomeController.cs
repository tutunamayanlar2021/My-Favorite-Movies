using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Logging;
using OrnekPro.Data;
using OrnekPro.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekPro.Controllers
{
    public class HomeController : Controller
    {   private readonly IHtmlLocalizer<HomeController> _localizer;
      //private readonly ILogger<HomeController> _logger;
     //DI
        private readonly MovieContext _context;
        public HomeController(MovieContext context, IHtmlLocalizer<HomeController> localizer)
        {
            _context = context;
            _localizer = localizer;
        }

    /*  public HomeController(ILogger<HomeController> logger)
        {
          //  _logger = logger;
            
        }*/

        public IActionResult Index()
        {
            var test = _localizer["film listesi"];
            ViewData["film listesi"] = test;
            var model = new HomePageViewModel
            {
                PopularMovies = _context.Movies.ToList()
            };
        
            return View(model);
        }
     
        public IActionResult About()
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
        
        [HttpPost]
        public IActionResult CultureManagment(string culture,string url)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions {Expires = DateTimeOffset.Now.AddDays(10)}) ;
            return LocalRedirect(url);
            
           
        }
    }
}
