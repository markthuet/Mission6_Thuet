using Microsoft.AspNetCore.Mvc;
using Mission6_Thuet.Models;
using System.Diagnostics;

namespace Mission6_Thuet.Controllers
{
    public class HomeController : Controller
    {

        private MovieContext _movieContext;
        public HomeController(MovieContext name) 

        {
            _movieContext = name;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnow()
        {
            return View();
        }

        [HttpGet]
        public IActionResult movieApplication()
        {
            return View();
        }

        [HttpPost]
        public IActionResult movieApplication(Movies response)
        {
            if (!ModelState.IsValid)
            {
                // There are validation errors, return to the form with errors
                return View(response);
            }

            _movieContext.Movies.Add(response); // Add record to database
            _movieContext.SaveChanges();

            return View("confirmation", response);
        }

    }
}
