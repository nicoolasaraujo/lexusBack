using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Lexus.Application.Services;
using Lexus.Core.Dto;
using Lexus.Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Lexus.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : CustomController
    {
        private readonly IUserService userService;
        private readonly IConfiguration configuration;

        public AuthController(IUserService userService, IConfiguration configuration)
        {
            this.userService = userService;
            this.configuration = configuration;
        }
            
        [HttpPost]
        [Route("login")]
        [Authorize]
        public IActionResult Login(LoginDto login)
        {
            var result = this.userService.Login(login.Username, login.Password);

            if (result.Succeeded)
            {
                //assinar jwt
                return CustomResponse(new { User = result.UserData, Token = TokenService.GenerateToken(configuration) } );
            }
            else
            {
                this.AddError("Usuário ou senha incorreto!");
                return CustomResponse();
            }
        }

    }
}
