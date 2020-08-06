using Lexus.Core.Dto;
using Lexus.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Lexus.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : CustomController
    {
        private readonly IUserService userService;
        private readonly ITokenService tokenService;

        public AuthController(
            IUserService userService, ITokenService tokenService)
        {
            this.userService = userService;
            this.tokenService = tokenService;
        }
            
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginDto login)
        {
            LoginResponse result = await this.userService.Login(login.Username, login.Password);

            if (result.Succeeded)
            {
                return CustomResponse(new { User = result.UserData.CustomData, Token = this.tokenService.GenerateToken(result.UserData) } );
            }
            else
            {
                return NotFound("Usuário ou senha incorretos");
            }
        }
    }
}
