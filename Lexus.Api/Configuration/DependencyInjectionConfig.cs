using Lexus.Application.Services;
using Lexus.Core.Interfaces.Repositories;
using Lexus.Core.Interfaces.Services;
using Lexus.Infra.Repositories;
using Lexus.Infra.Utils;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lexus.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterDependenciesInjection(this IServiceCollection services)
        {
            RegisterServices(services);
            RegisterRepositories(services);
        }

        private static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<ICryptoService, CryptoService>();
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(BaseRepository<>));
        }
    }
}
