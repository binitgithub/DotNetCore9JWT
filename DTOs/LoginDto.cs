using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore9JWT.DTOs
{
    public class LoginDto
    {
         public string Username { get; set; }
        public string Password { get; set; }
    }
}