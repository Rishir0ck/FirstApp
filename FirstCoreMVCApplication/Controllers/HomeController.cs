using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstCoreMVCApplication.Models;

namespace FirstCoreMVCApplication.Controllers;

public class HomeController : Controller
{
    public ViewResult Index()
    {
        List<Student> students = new List<Student>
        {
            new Student { StudentId = 1, Name = "John", Branch = "CSE", Section = "A",Gender = "Male"},
            new Student { StudentId = 2, Name = "Marry", Branch = "ECE", Section = "B",Gender = "Female"},
            new Student { StudentId = 3, Name = "Smith", Branch = "EEE", Section = "C",Gender = "Male"}



        };
        return View(students);
    }
    public ViewResult Details(int Id)
    {
        var student = new Student { StudentId = 1, Name = "John", Branch = "CSE", Section = "Q", Gender = "Male" };

        return View(student);
    }

}