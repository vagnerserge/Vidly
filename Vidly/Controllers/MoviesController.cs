using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }


        // GET: Movies
        //public ActionResult Random()
        //{

        //    var movie = new Movie { Name = "Shrek" };

        //    var customer = new List<Customer>
        //    {
        //        new Customer { Name = "Customer 1"},
        //        new Customer { Name = "Customer 2"}

        //    };

        //    var viewModel = new RandomMovieViewModel
        //    {
        //        Movie = movie,
        //        Customers = customer
        //    };

        //    return View(viewModel);
        //}



        public ActionResult Edit(int id) 
        {
            return Content("id = " + id);
        
        }

        public ActionResult Test(int? pageIndex, string sortBy) 
        {
            if (!pageIndex.HasValue) { pageIndex = 1; }

            if (string.IsNullOrWhiteSpace(sortBy)) { sortBy = "Name"; }

            return Content(string.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));
            
        }

        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {

            return Content(year + "/" + month);
        }

    }
}