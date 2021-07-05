using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Buildings;
using ApsiyonProject.Application.App.Common.Interfaces.Services.Buildings;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Infrastructure.Controllers.Building
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingTypeApiController : ControllerBase
    {
        private readonly IBuildingTypeCrudService _buildingTypeCrudService;

        public BuildingTypeApiController(IBuildingTypeCrudService buildingTypeCrudService)
        {
            _buildingTypeCrudService = buildingTypeCrudService;
        }

        [HttpPost("AddBuildingStatus")]
        public async Task<int> AddBuildingTypeAsync(BuildingTypeDto buildingTypeDto)
        {
            return await _buildingTypeCrudService.CreateBuildingTypeAsync(buildingTypeDto);
        }

        [HttpGet("GetBuildingStatusById")]
        public async Task<BuildingTypeDto> GetBuildingTypeByIdAsync(Guid id)
        {
            return await _buildingTypeCrudService.GetBuildingTypeByIdAsync(id);
        }

        [HttpGet("GetListBuildingStatus")]
        public async Task<List<BuildingTypeDto>> GetListBuildingTypeAsync()
        {
            return await _buildingTypeCrudService.GetListBuildingTypeAsync();
        }

    }
}
