using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Categories = _movieContext.Categories
                .ToList();


            // return View("movieApplication", new Movies());
            return View(new Movies());
        }

        // HTTP POST action method for processing movieApplication form submission
        [HttpPost]
        public IActionResult movieApplication(Movies response)
        {
            // Check if ModelState is not valid
            if (ModelState.IsValid)
            {
                // Add the movie record to the database
                _movieContext.Movies.Add(response);
                _movieContext.SaveChanges();

                // Redirect to the confirmation view with the movie response
                return View("confirmation", response);

            }
            else
            {
                ViewBag.Categories = _movieContext.Categories
               .ToList();

                return View(response);
            }
        }

        public IActionResult movieData()
        {
            //linq
            var movies = _movieContext.Movies.Include(m => m.Categories)
                .ToList();



            return View(movies);


        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var recordToEdit = _movieContext.Movies
                .Single(x => x.MovieId == Id);


            ViewBag.Categories = _movieContext.Categories
               .ToList();

            return View("movieApplication", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movies updatedInfo)
        {
            _movieContext.Update(updatedInfo);
            _movieContext.SaveChanges();


            return RedirectToAction("movieData");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _movieContext.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movies movies)
        {
            _movieContext.Movies.Remove(movies);
            _movieContext.SaveChanges();

            return RedirectToAction("movieData");
        }
    }
}
