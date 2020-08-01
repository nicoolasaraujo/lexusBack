using System;
using System.Collections.Generic;
using System.Text;

namespace Lexus.Core.Dto
{
    public class LoginResult
    {
        public LoginResponseDto UserData { get; set; }
        public bool Succeeded { get; set; }
    }
}
