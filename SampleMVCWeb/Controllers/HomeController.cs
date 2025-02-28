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

    public IActionResult Index()
    {
        return View();
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

    public ViewResult Details()
    {
        //USing ViewBag to pass data from controller to view
        ViewBag.Title = "Student Details Page";

        //Using ViewData to pass data from controller to view
        ViewData["Header"] = "Student Details";  

        //Cretaing an object of Student class
        Student student = new Student()
        {
            StudentId = 101,
            Name = "James",
            Branch = "CSE",
            Section = "A",
            Gender = "Male"
        };
        
        return View(student);

    }






}
