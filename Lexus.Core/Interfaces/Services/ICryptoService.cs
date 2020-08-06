using System;
using System.Collections.Generic;
using System.Text;

namespace Lexus.Core.Interfaces.Services
{
    public interface ICryptoService
    {
        public string HashPass(string pass, string salt);
    }
}
