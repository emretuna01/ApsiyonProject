using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Application.App.Common.Interfaces.Services;
using ApsiyonProject.Domain.App.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Infrastructure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApsiyonController : ControllerBase
    {
        private readonly IBuildingCrudService _buildingCrudService;
        private readonly IHouseOwnerCrudService _houseOwnerCrudService;
        private readonly IBuildingStatusCrudService _buildingStatusCrudService;
        public ApsiyonController(IBuildingCrudService buildingCrudService, IHouseOwnerCrudService houseOwnerCrudService, IBuildingStatusCrudService buildingStatusCrudService)
        {
            _buildingCrudService = buildingCrudService;
            _houseOwnerCrudService = houseOwnerCrudService;
            _buildingStatusCrudService = buildingStatusCrudService;
        }

        [HttpGet("GetRawListIncludeBuilding")] 
        public async Task<List<Building>> GetRawListIncludeBuildingAsync()
        {
            return await _buildingCrudService.GetRawListIncludeAsync();
        }

        [HttpGet("GetListIncludeBuilding")]
        public async Task<List<BuildingDto>> GetListIncludeBuildingAsync()
        {
            return await _buildingCrudService.GetListIncludeAsync();
        }

        [HttpGet("GetListBuildingStatus")]
        public async Task<List<BuildingStatusDto>> GetListBuildingStatusAsync()
        {
            return await _buildingStatusCrudService.GetListBuildingStatusAsync();
        }

        [HttpPost("AddBuilding")]
        public async Task<int> AddBuildingAsync(BuildingDto buildingDto)
        {
            return await _buildingCrudService.AddAsync(buildingDto);
        }

        [HttpPost("AddHouseOwner")]
        public async Task<int> AddHouseOwner(HouseOwnerDto houseOwnerDto)
        {
            return await _houseOwnerCrudService.AddAsync(houseOwnerDto);
        }
    }
}
