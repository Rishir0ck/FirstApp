using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstCoreMVCApplication.Models;

namespace FirstCoreMVCApplication.Controllers;

public class HomeController : Controller
{
    public ViewResult Index()
    {
        return View();
    }

    public ViewResult Details()
    {
        return View();
    }
}
