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
        ViewBag.Title = "Student Details Page";
        ViewBag.Header = "Student Details";  

        Student student = new Student()
        {
            StudentId = 101,
            Name = "James",
            Branch = "CSE",
            Section = "A",
            Gender = "Male"
        };
        
        ViewBag.Student = student;

        return View();

    }






}
