using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApsiyonProject.Application.App.Common.Interfaces.DbRepository;
using Microsoft.EntityFrameworkCore.Storage;

namespace ApsiyonProject.Application.App.Common.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    { 
        public IBuildingRepository Building { get; }
        public IBuildingStatusRepository BuildingStatus { get; }
        public IBuildingTypeRepository BuildingType { get; }
        public ICarRepository Car { get; }
        public IFlatRepository Flat { get; }
        public IFloorRepository Floor { get; }
        public IHouseOwnerRepository HouseOwner { get; }
        public Task<int> SaveChangesAsync();


    }
}
