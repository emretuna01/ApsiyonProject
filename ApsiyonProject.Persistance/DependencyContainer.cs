using ApsiyonProject.Application;
using ApsiyonProject.Application.App.Common.Interfaces.DbRepository;
using ApsiyonProject.Application.App.Common.Interfaces.Services;
using ApsiyonProject.Application.App.Common.Interfaces.Services.Buildings;
using ApsiyonProject.Application.App.Common.Interfaces.Services.Flats;
using ApsiyonProject.Application.App.Common.Interfaces.Services.Floors;
using ApsiyonProject.Application.App.Common.Interfaces.Services.HouseOwners;
using ApsiyonProject.Application.App.Common.Interfaces.UnitOfWork;
using ApsiyonProject.Persistance.App.Common;
using ApsiyonProject.Persistance.App.Persist;
using ApsiyonProject.Persistance.App.Services;
using ApsiyonProject.Persistance.App.Services.Accounts;
using ApsiyonProject.Persistance.App.Services.Buildings;
using ApsiyonProject.Persistance.App.Services.Buildings.Buildings;
using ApsiyonProject.Persistance.App.Services.Flats;
using ApsiyonProject.Persistance.App.Services.Floors;
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
            //TODO:MediatR kütüphanesi ve cqrs tasarımı implemnte edilecek
            //Context
            serviceCollection.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            //Repositories
            serviceCollection.AddScoped<IBuildingRepository, BuildingRepository>();
            serviceCollection.AddScoped<IBuildingStatusRepository, BuildingStatusRepository>();
            serviceCollection.AddScoped<IBuildingTypeRepository, BuildingTypeRepository>();
            serviceCollection.AddScoped<ICarRepository, CarRepository>();
            serviceCollection.AddScoped<IFlatRepository, FlatRepository>();
            serviceCollection.AddScoped<IFloorRepository, FloorRepository>();   
            serviceCollection.AddScoped<IHouseOwnerRepository, HouseOwnerRepository>();
            serviceCollection.AddScoped<IHouseOwnerRoleClaimsRepository, HouseOwnerRoleClaimsRepository>();
            serviceCollection.AddScoped<IHouseOwnerRolesRepository, HouseOwnerRolesRepository>();
            serviceCollection.AddScoped<IFlatTypeRepository, FlatTypeRepository>();
            serviceCollection.AddScoped<IFlatStatusRepository, FlatStatusRepository>();
            //App Service
            serviceCollection.AddApplicationService();
            //Crud Service
            serviceCollection.AddScoped<IBuildingCrudService, BuildingCrudService>();
            serviceCollection.AddScoped<IHouseOwnerCrudService, HouseOwnerCrudService>();
            serviceCollection.AddScoped<IBuildingStatusCrudService, BuildingStatusCrudService>();
            serviceCollection.AddScoped<IBuildingTypeCrudService, BuildingTypeCrudService>();
            serviceCollection.AddScoped<IFloorCrudService, FloorCrudService>();
            serviceCollection.AddScoped<IFlatCrudService, FlatCrudService>();
            serviceCollection.AddScoped<IFlatStatusCrudService, FlatStatusCrudService>();
            serviceCollection.AddScoped<IFlatTypeCrudService, FlatTypeCrudService>();            
            //CustomDto
            serviceCollection.AddCustomApplicationDtoService();
            //Unit Of Work
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
       

        }

    }
}
