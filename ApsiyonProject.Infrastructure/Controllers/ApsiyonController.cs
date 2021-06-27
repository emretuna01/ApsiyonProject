using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Application.App.Common.Interfaces.Services;
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
        public ApsiyonController(IBuildingCrudService buildingCrudService)
        {
            _buildingCrudService = buildingCrudService;
        }

        [HttpPost("AddBuilding")]
        public async Task<int>  AddBuilding(BuildingDto buildingDto)
        {
            return await _buildingCrudService.AddAsync(buildingDto); 
        }

    }
}
