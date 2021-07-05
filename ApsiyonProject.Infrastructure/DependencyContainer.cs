using ApsiyonProject.Infrastructure.Controllers;
using ApsiyonProject.Infrastructure.Controllers.Building;
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
            service.AddScoped<ApsiyonController>();
            service.AddScoped<BuildingStatusApiController>();
            
        }


    }
}
