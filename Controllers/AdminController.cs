using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore9JWT.Controllers
{
    [Authorize(Roles = "admin")] // Only Admins can access this controller
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        [HttpGet("dashboard")]
        public IActionResult GetDashboard()
        {
            return Ok("Welcome to the Admin Dashboard!");
        }
    }
}