using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Buildings;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.ViewComponents.Buildings
{
    public class BuildingStatusViewComponent : ViewComponent
    {
        private readonly BuildingStatusDto _buildingStatusDto;

        public BuildingStatusViewComponent(BuildingStatusDto buildingStatusDto)
        {
            _buildingStatusDto = buildingStatusDto;
        }

        public  IViewComponentResult Invoke()
        {           
            return View(_buildingStatusDto);
        }
    }
}
