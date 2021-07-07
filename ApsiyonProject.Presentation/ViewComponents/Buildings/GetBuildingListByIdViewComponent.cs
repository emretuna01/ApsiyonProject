using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Buildings;
using ApsiyonProject.Infrastructure.Controllers.Building;
using ApsiyonProject.Presentation.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.ViewComponents.Buildings
{
    public class GetBuildingListByIdViewComponent:ViewComponent
    {
        private readonly BuildingApiController _buildingApiController; 

        public GetBuildingListByIdViewComponent(BuildingApiController buildingApiController)
        {
            _buildingApiController = buildingApiController;
          
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userIdFromSession = HttpContext.Session.GetSessionType<Guid>("UserId");                        
            return View(await _buildingApiController.GetBuildingListByIdWithInculeListAsync(userIdFromSession));
        }
    }
}
