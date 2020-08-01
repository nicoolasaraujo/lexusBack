using Lexus.Core.Dto;
using Lexus.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lexus.Application.Services
{
    public class UserService : IUserService
    {
        public LoginResult Login(string username, string password)
        {
            return new LoginResult() { Succeeded = true, UserData = new { Username = username, AnotherField = "Hello42" } };
        }
    }
}
