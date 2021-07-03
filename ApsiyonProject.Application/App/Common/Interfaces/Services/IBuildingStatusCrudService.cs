using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Domain.App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Interfaces.Services
{
    public interface IBuildingStatusCrudService
    {
        public Task<List<BuildingStatusDto>> GetListBuildingStatusAsync();
        public Task<int> CreateListBuildingStatusAsync(BuildingStatusDto buildingStatus);
        public Task<BuildingStatusDto> GetBuildingStatusByIdAsync(Guid id);

    }
}
