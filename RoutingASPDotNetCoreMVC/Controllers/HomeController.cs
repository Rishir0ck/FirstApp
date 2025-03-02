 using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RoutingASPDotNetCoreMVC.Models;

namespace RoutingASPDotNetCoreMVC.Controllers;

[Route("[controller]/[action]")]
public class HomeController : Controller
{
    [Route("/")]
    
    public string Index()
    {
        return "Index() Action Method of HomeController";
    }

    
    public string Details()
    {
        return "Details() Action Method of HomeController";
    }

//comment for check we can use mobile for coding
    
}
