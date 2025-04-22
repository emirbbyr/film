using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using film.Models;

namespace film.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var filmler = Repository.Films;
        return View(filmler);
    }

    
}
