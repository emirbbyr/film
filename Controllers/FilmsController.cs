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

    public IActionResult details(int id)
{
    var filmler =Repository.GetById(id);
return View(filmler);
}
}
