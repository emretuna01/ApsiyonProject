using ApsiyonProject.Infrastructure.Controllers;
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
        }


    }
}
