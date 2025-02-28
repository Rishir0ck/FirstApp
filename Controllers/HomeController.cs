using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstApp.Models;
using Microsoft.AspNetCore.Authentication;

namespace FirstApp.Controllers;

public class HomeController : Controller
{
    //create a referance variable of IStudentRepository
    private readonly IStudentRepository? _repository = null;
    private readonly SomeOtherService? _someOtherService = null;

    
    //Initialize the repository in the constructor
    public HomeController(IStudentRepository repository, SomeOtherService someOtherService)
    {
        _repository = repository;
        _someOtherService = someOtherService;
    }

    public JsonResult Index()
    {
        List<Student>? allStudentDetails = _repository?.GetAllStudents();
        return Json(allStudentDetails);
    }

    public JsonResult GetStudentDetails(int Id)
    {
        Student? studentDetails = _repository?.GetStudentById(Id);
        return Json(studentDetails);
    }




}
