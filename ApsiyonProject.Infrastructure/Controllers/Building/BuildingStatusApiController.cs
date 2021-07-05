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
    public class BuildingStatusApiController : ControllerBase
    {
        private readonly IBuildingStatusCrudService _buildingStatusCrudService;

        public BuildingStatusApiController(IBuildingStatusCrudService buildingStatusCrudService)
        {
            _buildingStatusCrudService = buildingStatusCrudService;
        }

        [HttpPost("AddBuildingStatus")]
        public async Task<int> AddBuildingStatusAsync(BuildingStatusDto buildingStatusDto)
        {
            return await _buildingStatusCrudService.CreateBuildingStatusAsync(buildingStatusDto);
        }

        [HttpGet("GetBuildingStatusById")]
        public async Task<BuildingStatusDto> GetBuildingStatusByIdAsync(Guid id)
        {
            return await _buildingStatusCrudService.GetBuildingStatusByIdAsync(id);
        }

        [HttpGet("GetListBuildingStatus")]
        public async Task<List<BuildingStatusDto>> GetListBuildingStatusAsync()
        {
            return await _buildingStatusCrudService.GetListBuildingStatusAsync();

        }

   
    }
}
