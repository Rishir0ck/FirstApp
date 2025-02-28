using FirstApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    // [Route("api/[controller]")]
    // [ApiController]
    public class StudentController : ControllerBase
    {
        // GET: api/Student
        // [HttpGet]
        // public IActionResult Get()
        // {
        //     ErrorViewModel r1 = new ErrorViewModel();
        //     return Ok("Get All Students");
        // }

        // public string GetAllStudents()
        // {
        //     return "Return All Students yeyeyeye";
        // }

        // public string GetStudentsByName(string name)
        // {
        //     return $"Return Student by Name : {name}";
        // }
        public JsonResult GetStudentDetails (int Id)
        {
            StudentRepository studentRepository = new StudentRepository();
            Student student = studentRepository.GetStudentById(Id);
            return new JsonResult(student);
        }

    }
}
