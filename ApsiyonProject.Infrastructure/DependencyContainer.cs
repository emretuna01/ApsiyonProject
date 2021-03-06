using ApsiyonProject.Infrastructure.Controllers;
using ApsiyonProject.Infrastructure.Controllers.Account;
using ApsiyonProject.Infrastructure.Controllers.Building;
using ApsiyonProject.Infrastructure.Controllers.Flats;
using ApsiyonProject.Infrastructure.Controllers.Floors;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Infrastructure
{
    public static class DependencyContainer
    {

        public static void AddInfrastructureService(this IServiceCollection service)
        {
            service.AddScoped<BuildingApiController>();
            service.AddScoped<BuildingStatusApiController>();
            service.AddScoped<BuildingTypeApiController>();
            service.AddScoped<HouseOwnerApiController>();
            service.AddScoped<FloorApiController>();
            service.AddScoped<FlatApiController>();
            service.AddScoped<FlatStatusApiController>();
            service.AddScoped<FlatTypeApiController>();           

        }


    }
}
