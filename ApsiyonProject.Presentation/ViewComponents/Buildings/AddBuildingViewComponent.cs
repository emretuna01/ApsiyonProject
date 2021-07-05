using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Buildings;
using ApsiyonProject.Infrastructure.Controllers;
using ApsiyonProject.Infrastructure.Controllers.Building;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.ViewComponents.Buildings
{
    public class AddBuildingViewComponent:ViewComponent
    {
        private readonly BuildingTypeApiController _buildingTypeApiController;
        private readonly BuildingStatusApiController _buildingStatusApiController;
        private readonly AddBuildingDto _addBuildingDto;
        public AddBuildingViewComponent(BuildingStatusApiController buildingStatusApiController, BuildingTypeApiController buildingTypeApiController, AddBuildingDto addBuildingDto)
        {

            _buildingStatusApiController = buildingStatusApiController;
            _buildingTypeApiController = buildingTypeApiController;
            _addBuildingDto = addBuildingDto;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {           
            ViewBag.BuildingStatus = await _buildingStatusApiController.GetListBuildingStatusAsync();
            ViewBag.BuildingType = await _buildingTypeApiController.GetListBuildingTypeAsync();
            return View(_addBuildingDto);
        }
    }
}
