using ApsiyonProject.Application.App.Common.Interfaces.DbRepository;
using ApsiyonProject.Application.App.Common.Interfaces.UnitOfWork;
using ApsiyonProject.Persistance.App.Common;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Persistance.App.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UnitOfWork(ApplicationDbContext applicationDbContext, IBuildingRepository building, IBuildingStatusRepository buildingStatus, IBuildingTypeRepository buildingType, ICarRepository car, IFlatRepository flat, IFloorRepository floor, IHouseOwnerRepository houseOwner, IFlatTypeRepository flatType, IFlatStatusRepository flatStatus)
        {
            _applicationDbContext = applicationDbContext;
            Building = building;
            BuildingStatus = buildingStatus;
            BuildingType = buildingType;
            Car = car;
            Flat = flat;
            Floor = floor;
            HouseOwner = houseOwner;
            FlatType= flatType;
            FlatStatus = flatStatus;
        }

        public IBuildingRepository Building { get; }
        public IBuildingStatusRepository BuildingStatus { get; }
        public IBuildingTypeRepository BuildingType { get; }
        public ICarRepository Car { get; }
        public IFlatRepository Flat { get; }
        public IFlatStatusRepository FlatStatus { get; }
        public IFlatTypeRepository FlatType { get; }
        public IFloorRepository Floor { get; }
        public IHouseOwnerRepository HouseOwner { get; }
        public IHouseOwnerRoleClaimsRepository HouseOwnerRoleClaims { get; }
        public IHouseOwnerRolesRepository HouseOwnerRoles { get; }
        public async Task<int> SaveChangesAsync()
        {     
            return await _applicationDbContext.SaveChangesAsync();
        }



    }
}
