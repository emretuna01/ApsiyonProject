﻿using ApsiyonProject.Application.App.Common.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Buildings;
using ApsiyonProject.Application.App.Common.Interfaces.Services.Buildings;

namespace ApsiyonProject.Infrastructure.Controllers.Building
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingApiController : ControllerBase
    {
        private readonly IBuildingCrudService _buildingCrudService;

        public BuildingApiController(IBuildingCrudService buildingCrudService)
        {
            _buildingCrudService = buildingCrudService;
        }

        [HttpPost("AddBuilding")]
        public async Task<int> AddBuildingAsync(AddBuildingDto addBuildingDto)
        {
            return await _buildingCrudService.AddAsync(addBuildingDto);
        }
        
        /*
        [HttpGet("GetRawListIncludeBuilding")]
        public async Task<List<BuildingEntities.Building>> GetRawListIncludeBuildingAsync()
        {
            return await _buildingCrudService.GetRawListIncludeAsync();
        }

        [HttpGet("GetListIncludeBuilding")]
        public async Task<List<BuildingDto>> GetListIncludeBuildingAsync()
        {
            return await _buildingCrudService.GetListIncludeAsync();
        }
        */

    }
}
