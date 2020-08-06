using System;
using System.Collections.Generic;
using System.Text;

namespace Lexus.Core.Dto
{
    public class LoginResponseDto
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public object CustomData { get; set; }
    }
}
