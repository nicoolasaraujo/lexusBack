using Lexus.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lexus.Core.Interfaces.Services
{
    public interface ITokenService
    {
        public string GenerateToken(LoginResponseDto loginResult);
    }
}
