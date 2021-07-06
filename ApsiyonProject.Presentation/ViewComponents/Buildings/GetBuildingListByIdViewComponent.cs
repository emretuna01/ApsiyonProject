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
        private readonly List<GetBuildingListDto> _getBuildingListDtos;

        public GetBuildingListByIdViewComponent(BuildingApiController buildingApiController, List<GetBuildingListDto> getBuildingListDtos)
        {
            _buildingApiController = buildingApiController;
            _getBuildingListDtos = getBuildingListDtos;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userIdFromSession = HttpContext.Session.GetSessionType<Guid>("UserId");            
            return View(await _buildingApiController.GetBuildingListByIdWithInculeListAsync(userIdFromSession));
        }
    }
}
