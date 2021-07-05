using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Buildings;
using ApsiyonProject.Infrastructure.Controllers.Building;
using ApsiyonProject.Presentation.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.Controllers.Buildings
{
    public class BuildingController : Controller
    {
        readonly private BuildingApiController _buildingApiController;

        public BuildingController(BuildingApiController buildingApiController)
        {
            _buildingApiController = buildingApiController;
        }
        public ActionResult AddBuilding()
        {
            return ViewComponent("AddBuilding");
        }
        [HttpPost]
        public async Task<ActionResult> AddBuilding(AddBuildingDto addBuildingDto)
        {
            var userIdFromSession = HttpContext.Session.GetSessionType<Guid>("UserId");
            addBuildingDto.AdministratorId = userIdFromSession;
            ViewBag.AddCountMessage = await _buildingApiController.AddBuildingAsync(addBuildingDto);
            return RedirectToAction("Index","Account");
        }

        
    }
}
