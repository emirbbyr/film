using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using film.Models;

namespace film.Controllers;

public class FilmsController : Controller
{
    public IActionResult filmler()
    {
        var filmler = Repository.Films;  // ✅ film listesini al
        return View(filmler);            // ✅ View'a gönder
    }


}
