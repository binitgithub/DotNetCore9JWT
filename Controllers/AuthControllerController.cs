using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore9JWT.DTOs;
using DotNetCore9JWT.Helpers;
using DotNetCore9JWT.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore9JWT.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthControllerController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public AuthControllerController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
    [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            var user = await _userRepository.GetUserByUsernameAsync(dto.Username);
            if (user == null || user.PasswordHash != dto.Password) // Hashing to be added
                return Unauthorized();

            var token = JwtHelper.GenerateJwtToken(user.Username, user.Role, "dA6X6aIDdZQ2Wq69ascT8oDtn1FIuxyA");
            return Ok(new { Token = token });
        }
    }
}