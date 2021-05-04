using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
namespace TestChatApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {

        private static readonly string[] UserNames = new string[]
            {
                "Chris", "Andy", "Ahmed"
            };

        public UsersController()
        {
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return Enumerable.Range(0, 3).Select(index => new User
            {
                Id = index,
                Name = UserNames[index]
            }); 
        }
    }
}
