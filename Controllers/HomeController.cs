using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstApp.Models;
using Microsoft.AspNetCore.Authentication;

namespace FirstApp.Controllers;

public class HomeController : Controller
{
    // private readonly ILogger<HomeController> _logger;

    // public HomeController(ILogger<HomeController> logger)
    // {
    //     _logger = logger;
    // }

    // public IActionResult Index()
    // {
    //     return View();
    // }

    // public IActionResult Privacy()
    // {
    //     return View();
    // }

    // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    // public IActionResult Error()
    // {
    //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    // }

    // public ViewResult Index()
    // {
    //     return View();
    // }

    //Create an instance of the repository
    private readonly IStudentRepository? _repository = null;

    //Initialize the repository in the constructor
    public HomeController(IStudentRepository repository)
    {
        _repository = repository;
    }

    public JsonResult Index()
    {
        List<Student>? allStudentDetails = _repository?.GetAllStudents();
        return Json(allStudentDetails);
    }

    public JsonResult GetStudentDetails(int id)
    {
        Student? studentDetails = _repository?.GetStudentById(id);
        return Json(studentDetails);
    }




}
