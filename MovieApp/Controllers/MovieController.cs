using Microsoft.AspNetCore.Mvc;
using MovieApp.Models.Db;

namespace MovieApp.Controllers
{
    public class MovieController : Controller
    {
        MovieContext c = new MovieContext();
        
        public IActionResult Index()
        {
            var values = c.Movies.ToList();
            return View(values);

        }
    }
}
