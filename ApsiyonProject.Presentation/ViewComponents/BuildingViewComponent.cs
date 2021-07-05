using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Infrastructure.Controllers;
using ApsiyonProject.Infrastructure.Controllers.Building;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.ViewComponents
{
    public class BuildingViewComponent:ViewComponent
    {
        private readonly BuildingTypeApiController _buildingTypeApiController;
        private readonly BuildingStatusApiController _buildingStatusApiController;
        private readonly BuildingDto _buildingDto;
        public BuildingViewComponent(BuildingDto buildingDto, BuildingStatusApiController buildingStatusApiController, BuildingTypeApiController buildingTypeApiController)
        {
            _buildingDto = buildingDto;
            _buildingStatusApiController = buildingStatusApiController;
            _buildingTypeApiController = buildingTypeApiController;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {           
            ViewBag.BuildingStatus = await _buildingStatusApiController.GetListBuildingStatusAsync();
            ViewBag.BuildingType = await _buildingTypeApiController.GetListBuildingTypeAsync();
            return View(_buildingDto);
        }
    }
}
