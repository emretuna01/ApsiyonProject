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
    public class BuildingTypeApiController : ControllerBase
    {
        private readonly IBuildingTypeCrudService _buildingTypeCrudService;

        public BuildingTypeApiController(IBuildingTypeCrudService buildingTypeCrudService)
        {
            _buildingTypeCrudService = buildingTypeCrudService;
        }

        [HttpGet("GetListBuildingType")]
        public async Task<List<BuildingTypeDto>> GetListBuildingTypeAsync()
        {
            return await _buildingTypeCrudService.GetListBuildingTypeAsync();
        }

    }
}
