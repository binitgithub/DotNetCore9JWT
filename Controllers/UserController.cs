using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore9JWT.Controllers
{
    [Authorize(Roles = "user,admin")] // Both Users and Admins can access
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
       [HttpGet("profile")]
        public IActionResult GetProfile()
        {
            return Ok("Welcome to the User Profile!");
        } 
    }
}