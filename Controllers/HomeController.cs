using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrimerMvcSena.Models;

namespace PrimerMvcSena.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Persona juan = new Persona();
        juan.name = "pablo";
        juan.edad = 21;
        return View(juan);
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
}
