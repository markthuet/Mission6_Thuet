using Microsoft.AspNetCore.Mvc;
using Mission6_Thuet.Models;
using System.Diagnostics;

namespace Mission6_Thuet.Controllers
{
    // HomeController class definition
    public class HomeController : Controller
    {
        // Private field to store MovieContext instance
        private MovieContext _movieContext;

        // Constructor for HomeController with MovieContext parameter
        public HomeController(MovieContext name)
        {
            _movieContext = name;
        }

        // Action method for the Index view
        public IActionResult Index()
        {
            return View();
        }

        // Action method for the GetToKnow view
        public IActionResult GetToKnow()
        {
            return View();
        }

        // HTTP GET action method for the movieApplication view
        [HttpGet]
        public IActionResult movieApplication()
        {
            return View();
        }

        // HTTP POST action method for processing movieApplication form submission
        [HttpPost]
        public IActionResult movieApplication(Movies response)
        {
            // Check if ModelState is not valid
            if (!ModelState.IsValid)
            {
                // There are validation errors, return to the form with errors
                return View(response);
            }

            // Add the movie record to the database
            _movieContext.Movies.Add(response);
            _movieContext.SaveChanges();

            // Redirect to the confirmation view with the movie response
            return View("confirmation", response);
        }
    }
}
