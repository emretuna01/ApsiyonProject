using ApsiyonProject.Application;
using ApsiyonProject.Application.App.Common.Interfaces.DbRepository;
using ApsiyonProject.Application.App.Common.Interfaces.Services;
using ApsiyonProject.Application.App.Common.Interfaces.UnitOfWork;
using ApsiyonProject.Domain.App.Entities;
using ApsiyonProject.Persistance.App.Common;
using ApsiyonProject.Persistance.App.Persist;
using ApsiyonProject.Persistance.App.Services;
using ApsiyonProject.Persistance.App.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Persistance
{
    public static class DependencyContainer
    {
        public static void AddPersistanceFundamentalService(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            serviceCollection.AddScoped<IBuildingRepository, BuildingRepository>();
            serviceCollection.AddScoped<IBuildingStatusRepository, BuildingStatusRepository>();
            serviceCollection.AddScoped<IBuildingTypeRepository, BuildingTypeRepository>();
            serviceCollection.AddScoped<ICarRepository, CarRepository>();
            serviceCollection.AddScoped<IFlatRepository, FlatRepository>();
            serviceCollection.AddScoped<IFloorRepository, FloorRepository>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<IHouseOwnerRepository, HouseOwnerRepository>();
            serviceCollection.AddScoped<IHouseOwnerRoleClaimsRepository, HouseOwnerRoleClaimsRepository>();
            serviceCollection.AddScoped<IHouseOwnerRolesRepository, HouseOwnerRolesRepository>();
            serviceCollection.AddApplicationService();
            serviceCollection.AddScoped<IBuildingCrudService, BuildingCrudService>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();

        }

    }
}
