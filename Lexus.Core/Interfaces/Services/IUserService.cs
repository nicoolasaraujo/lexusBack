using Lexus.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lexus.Core.Interfaces.Services
{
    public interface IUserService
    {
        Task<LoginResponse> Login(string username, string password);
    }
}
