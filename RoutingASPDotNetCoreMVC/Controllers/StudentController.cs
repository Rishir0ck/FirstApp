using Microsoft.AspNetCore.Mvc;

namespace RoutingASPDotNetCoreMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: StudentController
        public string Index(string id)
        {
            return $"Index({id}) Action Method of StudentController";
        }
        public string Details(string id)
        {
            return $"Details({id}) Action Method of StudentController";
        }

    }
}
