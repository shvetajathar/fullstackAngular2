using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using jwtapi.Models;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
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
            if(userObj==null) 
            return BadRequest();
            var user=await _authContext.Users.FirstOrDefaultAsync(x=>x.UserName==userObj.UserName);
            if(user==null)
            {
                return NotFound(new {Message="User Not Found"});
            }
            user.Token=CreateJwt(user);
            var newAccessToken=user.Token;
            var newRefreshToken=CreateRefreshToken();
            user.RefreshTokenExpiryTime=DateTime.Now.AddDays(2);
            await _authContext.SaveChangesAsync();
            return Ok(new TokenApi(){
                AccessToken=newAccessToken,
                RefreshToken=newRefreshToken

            });

        }
        [HttpPost("register")]
        public async Task<IActionResult> AddUser([FromBody] User userObj)
        {
            if(userObj==null) return BadRequest();
            //if any other validation is required before storing in database do it here
            userObj.Role="user";
            userObj.Token="";
            await _authContext.Users.AddAsync(userObj);
            await _authContext.SaveChangesAsync();
            return Ok();
        
        }

        private string createJwt(User user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var key=Encoding.ASCII.GetBytes("ltimindtree...");
            var identity=new ClaimsIdentity(new Claim[]{
                new Claim(ClaimTypes.Role,user.Role),
                new Claim(ClaimType.Name,$"{user.UserName}")


            });
            var credentials=new SigningCredentials(new SymmetricSecurityKey(key),
            SecurityAlgorithms.HmacSha256);
            var tokenDescriptor=new SecurityTokenDescriptor{
                Subject=identity,
                Expires=DateTime.Now.AddDays(2),
                SigningCredentials=credentials
            };
            var token=jwtTokenHandler.CreateToken(tokenDescriptor);
            return jwtTokenHandler.WriteToken(token);

  
        }
        private string CreateRefreshToken()
        {
            var tokenBytes=RandomNumberGenerator.GetBytes(64);
            var refreshtoken=Convert.ToBase64String(tokenBytes);
            var tokenInuser=_authContext.Users.Any(a=>a.RefreshToken==refreshtoken);
            if(tokenInuser)
            {
                return CreateRefreshToken();
            }
            return refreshtoken;
        }
}
}