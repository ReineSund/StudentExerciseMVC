using Microsoft.AspNetCore.Mvc;
using StudentExerciseMVC.Models;

namespace StudentExerciseMVC.Controllers
{
  public class MovieController : Controller
  {
    private static List<MovieViewModel> _movies = new List<MovieViewModel>();
    public IActionResult Index()
    {
      //MovieViewModel movie = new MovieViewModel()
      //{ MovieTitle = "The Godfather", Director = "Francis Ford Coppola", Year = 1972 };
      //return View(movie);
      return View(_movies);
    }

    public IActionResult Create()
    {
      var movieVm = new MovieViewModel();
      return View(movieVm);
    }

    public IActionResult CreateMovie(MovieViewModel movieViewModel)
    {
      _movies.Add(movieViewModel);
      return RedirectToAction(nameof(Index));
      //return View("Index");
    }
  }

  
}
