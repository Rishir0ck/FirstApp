using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RoutingASPDotNetCoreMVC.Models;

namespace RoutingASPDotNetCoreMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

     [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public string Index()
        {
            return "Index() Action Method of HomeController";
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

    [Route("Home/Details/{id}")]
        public string Details(int id)
        {
            return "Details() Action Method of HomeController, ID Value = " + id;
        }


    
}

