using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jwtapi.Models
{
    public class User
    {
        public int Id{get;set;}
        public string? FirstName{get;set;}
        public string? lastName{get;set;}
        public string? UserName{get;set;}
        public string? Password{get;set;}
        public string? Token{get;set;}
        public string? Role{get;set;}
        public string? Email{get;set;}
        public string? RefreshToken{get;set;}
        public DateTime RefreshTokenExpiryTime{get;set;}
    }
    public class TokenApi{
        public string AccessToken{get;set;}=string.Empty;
        public string RefreshToken{get;set;}=string.Empty;
        

    }
}