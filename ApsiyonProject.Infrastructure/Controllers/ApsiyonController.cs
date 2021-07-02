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
        private readonly IHouseOwnerCrudService _houseOwnerCrudService;
        public ApsiyonController(IBuildingCrudService buildingCrudService, IHouseOwnerCrudService houseOwnerCrudService)
        {
            _buildingCrudService = buildingCrudService;
            _houseOwnerCrudService = houseOwnerCrudService;
        }

        public async Task<List<BuildingDto>> GetBuildingAsync()
        {
            return await _buildingCrudService.GetListAsync();
        }


        [HttpPost("AddBuilding")]
        public async Task<int>  AddBuildingAsync(BuildingDto buildingDto)
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
