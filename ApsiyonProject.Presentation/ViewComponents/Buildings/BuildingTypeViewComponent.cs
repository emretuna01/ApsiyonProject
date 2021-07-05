using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Buildings;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.ViewComponents.Buildings
{
    public class BuildingTypeViewComponent:ViewComponent
    {
        private readonly BuildingTypeDto _buildingTypeDto;

        public BuildingTypeViewComponent(BuildingTypeDto buildingTypeDto)
        {
            _buildingTypeDto = buildingTypeDto;
        }

        public IViewComponentResult Invoke()
        {
            return View(_buildingTypeDto);
        }
    }
}
