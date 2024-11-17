using Microsoft.Extensions.DependencyInjection;
using MonitoraEquipamentos.Application;
using MonitoraEquipamentos.Application.Contract;
using MonitoraEquipamentos.Repo;
using MonitoraEquipamentos.Repo.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoraEquipamentos.api.Extensios
{
    public static class ConfigurationExtensions
    {

        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IEquipamentoService, EquipamentoService>();
            return services;
        }

        public static IServiceCollection AddInfraestructure(this IServiceCollection services)
        {
            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<IEquipamentoRepo, EquipamentoRepo>();
            return services;
        }

        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return services;
        }
    }
}
