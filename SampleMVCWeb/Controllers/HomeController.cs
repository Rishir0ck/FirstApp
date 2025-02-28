using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SampleMVCWeb.Models;

namespace SampleMVCWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
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

   public ActionResult Index()
    {
        TempData["Name"] = "Rishi";
        TempData["Age"] = "22";
        return View();
    }

    public ActionResult About()
    {
        return View();
    }





}
