using Microsoft.AspNetCore.Mvc;

namespace RoutingASPDotNetCoreMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: StudentController
        public string Index()
        {
            return $"Index() Action Method of StudentController";
        }
        public string Details(string id)
        {
            return $"Details({id}) Action Method of StudentController";
        }

    }
}
