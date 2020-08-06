using Lexus.Core.Interfaces.Services;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lexus.Infra.Utils
{
    public class CryptoService : ICryptoService
    {
        public string HashPass(string pass, string salt)
        {
            var bsalt = Encoding.ASCII.GetBytes(salt);
            var hashed = KeyDerivation.Pbkdf2(
                password: pass,
                salt: bsalt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8
            );
            return Convert.ToBase64String(hashed);
        }
    }
}
