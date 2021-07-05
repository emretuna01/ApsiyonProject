using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Interfaces.Services.Buildings
{
    public interface IBuildingTypeCrudService
    {
        public Task<int> CreateBuildingTypeAsync(BuildingTypeDto buildingStatus);
        public Task<BuildingTypeDto> GetBuildingTypeByIdAsync(Guid id);
        public Task<List<BuildingTypeDto>> GetListBuildingTypeAsync();
    }

}
