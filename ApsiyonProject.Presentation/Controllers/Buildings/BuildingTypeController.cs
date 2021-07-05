using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Buildings;
using ApsiyonProject.Infrastructure.Controllers.Building;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.Controllers.Buildings
{
    public class BuildingTypeController : Controller
    {
        private readonly BuildingTypeApiController _buildingTypeApiController;

        public BuildingTypeController(BuildingTypeApiController buildingTypeApiController)
        {
            _buildingTypeApiController = buildingTypeApiController;
        }
        
        public IActionResult AddBuildingType()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddBuildingType(BuildingTypeDto buildingTypeDto)
        {
            await _buildingTypeApiController.AddBuildingTypeAsync(buildingTypeDto);
            return RedirectToAction("Index", "Account");
        }
    }
}
