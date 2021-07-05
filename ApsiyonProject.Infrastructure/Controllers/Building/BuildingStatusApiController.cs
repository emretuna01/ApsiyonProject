using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Application.App.Common.Interfaces.Services;
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

        [HttpGet("GetListBuildingStatus")]
        public async Task<List<BuildingStatusDto>> GetListBuildingStatusAsync()
        {
            return await _buildingStatusCrudService.GetListBuildingStatusAsync();
        }

        [HttpPost("AddBuildingStatus")]
        public async Task<int> AddBuildingStatusAsync(BuildingStatusDto buildingStatusDto)
        {
            return await _buildingStatusCrudService.CreateBuildingStatusAsync(buildingStatusDto);
        }

    }
}
