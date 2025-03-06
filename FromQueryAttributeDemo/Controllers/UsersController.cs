using FromQueryAttributeDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace FromQueryAttributeDemo.Controllers
{
    public class UsersController : Controller
    {
        private List<User>  _users;

        public UsersController()
        {
            _users = new List<User>()
            {
                new User(){Id = 1, Name = "John", Age = 25, Mobile = "1234567890"},
                new User(){Id = 2, Name = "Jane", Age = 30, Mobile = "1234567890"}, 
                new User(){Id = 3, Name = "Doe", Age = 35, Mobile = "1234567890"},
                new User(){Id = 4, Name = "Smith", Age = 40, Mobile = "1234567890"},
                new User(){Id = 5, Name = "Doe", Age = 45, Mobile = "1234567890"},
            };
        }

        [HttpGet]
        [Route("users/{Id}/getdetails")]
        public IActionResult GetUserById([FromRoute(Name ="Id")] int UserId)
        {
            var user = _users.FirstOrDefault(u => u.Id == UserId);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }



    }
}
