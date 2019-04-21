using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pos_app.Models;

namespace pos_app.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private static string[] UserRoles = new[]
        {
            "Associate", "Manager", "Admin"
        };

        [HttpGet("[action]")]
        public IEnumerable<User> GetUsers()
        {
            //return ViewResult();
        }
    }
}
