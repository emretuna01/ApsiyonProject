using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Buildings;
using ApsiyonProject.Domain.App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Interfaces.Services.Buildings
{
    public interface IBuildingStatusCrudService
    {
        public Task<int> CreateBuildingStatusAsync(BuildingStatusDto buildingStatus);
        public Task<BuildingStatusDto> GetBuildingStatusByIdAsync(Guid id);
        public Task<List<BuildingStatusDto>> GetListBuildingStatusAsync();
    }
}
