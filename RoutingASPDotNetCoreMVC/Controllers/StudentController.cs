using Microsoft.AspNetCore.Mvc;
using RoutingASPDotNetCoreMVC.Models;

namespace RoutingASPDotNetCoreMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: StudentController
        static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "John" },
            new Student { Id = 2, Name = "Jane" },
            new Student { Id = 3, Name = "Doe" }
        };

        [Route("Student/GetAllStudents")]
        public List<Student> GetAllStudents()
        {
            return students;
        }

        [Route("Student/{studentId}/Details")]
        public Student GetStudentById(int studentId)
        {
            Student? studentDetails = students.FirstOrDefault(s => s.Id == studentId);
            return studentDetails ?? new Student();
        }

        [Route("Student/{studentId}/Courses")]
        public List<string> GetStudentCourses(int studentId)
        {
            List<string> coursesList = new List<string>();
            
            if (studentId == 1)
            {
                coursesList.Add("Maths");
                coursesList.Add("Science");
            }
            else if (studentId == 2)
            {
                coursesList.Add("English");
                coursesList.Add("History");
            }
            else if (studentId == 3)
            {
                coursesList.Add("Geography");
                coursesList.Add("Computer Science");
            }
            
            
            return coursesList;
        }



    }
}
