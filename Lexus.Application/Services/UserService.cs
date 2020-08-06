using Lexus.Core.Dto;
using Lexus.Core.Interfaces.Repositories;
using Lexus.Core.Interfaces.Services;
using Lexus.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lexus.Application.Services
{
    public class UserService : IUserService
    {
        private readonly ICryptoService CryptoService;
        private readonly IRepositoryBase<User> UserRepository;
        public UserService(ICryptoService crypto, IRepositoryBase<User> userRepository)
        {
            this.CryptoService = crypto;
            this.UserRepository = userRepository;
        }


        public async Task<LoginResponse> Login(string username, string password)
        {
            var userData = await this.UserRepository.GetFirstByCondition(u => u.Username == username);

            if (userData == null)
            {
                return new LoginResponse() { Succeeded = false, UserData = null };
            }

            string encryptedPass = this.CryptoService.HashPass(password, userData.Id.ToString());
            if (encryptedPass == userData.Password)
            {
                return new LoginResponse() { Succeeded = true, UserData = new LoginResponseDto() {  Id = userData.Id, FirstName = "Teste", CustomData = userData } };
            }
            else
            {
                return new LoginResponse() { Succeeded = false, UserData = null };
            }
        }
    }
}
