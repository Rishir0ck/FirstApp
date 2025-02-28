using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleMVCWeb.Models;
using SampleMVCWeb.Models.ViewModels;

namespace SampleMVCWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        public ViewResult Details()
        {
            //Student Basic Details
            Student student = new Student()
            {
                StudentId = 101,
                Name = "James",
                Branch = "CSE",
                Section = "A",
            };

            //Student Address Details
            Address address = new Address()
            {
                StudentId = 101,
                City = "New York",
                State = "New York",
                Country = "USA",
                PinCode = "10001"
            };

            // Create a ViewModel to pass both student and address details to the view
            StudentDetailsViewModel viewModel = new StudentDetailsViewModel()
            {
                Student = student,
                Address = address,
                Title = "Student Details Page",
                Header = "Student Details"
            };

            return View(viewModel);
        }



    }
}
