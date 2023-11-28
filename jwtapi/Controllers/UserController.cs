using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using jwtapi.Models;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdenitityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace jwtapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly AppdContext _authContext;
        public UserController(AppdContext context)
        {
            _authContext=context;
        }
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] User userObj)
        {
            if(userObj==null) return BadRequest();
            var user=await _authContext.Users.FirstOrDefaultAsync(x=>x.Username==userObj.Username);

        }
        
    }
}