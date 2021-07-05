using ApsiyonProject.Application.App.Common.Interfaces.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using System.Reflection;
using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Application.App.Common.Interfaces.Dtos.HouseOwners;

namespace ApsiyonProject.Application
{
    public static class DependencyContainer
    {
        public static void AddApplicationService(this IServiceCollection services)
        {           
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
        public static void AddApplicationDtoService(this IServiceCollection services)
        {
            services.AddScoped<HouseOwnerInitDto>();
            services.AddScoped<BuildingDto>();
            services.AddScoped<BuildingStatusDto>();
            services.AddScoped<LoginUserDto>();
        }

    }
}
