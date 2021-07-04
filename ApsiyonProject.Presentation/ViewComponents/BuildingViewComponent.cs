using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Infrastructure.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.ViewComponents
{
    public class BuildingViewComponent:ViewComponent
    {
        private readonly ApsiyonController _apsiyonController;
        private readonly BuildingDto _buildingDto;
        public BuildingViewComponent(ApsiyonController apsiyonController, BuildingDto buildingDto)
        {
            _apsiyonController = apsiyonController;
            _buildingDto = buildingDto;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {           
            ViewBag.BuildingStatus = await _apsiyonController.GetListBuildingStatusAsync();
            ViewBag.BuildingType = await _apsiyonController.GetListBuildingTypeAsync();
            return View(_buildingDto);
        }
    }
}
