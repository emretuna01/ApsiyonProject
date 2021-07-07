﻿using ApsiyonProject.Application.App.Common.Interfaces.UnitOfWork;
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
using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Buildings;
using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Floors;

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
            services.AddScoped<AddBuildingDto>();
            services.AddScoped<BuildingStatusDto>();
            services.AddScoped<LoginUserDto>();
            services.AddScoped<BuildingTypeDto>();
            services.AddScoped<List<GetBuildingListDto>>();
            services.AddScoped<FloorDto>();
        }
        public static void AddCustomApplicationDtoService(this IServiceCollection services)
        {          
            services.AddScoped<List<FloorDto>>();
        }

    }
}
