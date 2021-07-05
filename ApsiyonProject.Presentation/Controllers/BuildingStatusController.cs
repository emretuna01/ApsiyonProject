using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Buildings;
using ApsiyonProject.Infrastructure.Controllers.Building;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.Controllers
{
    public class BuildingStatusController : Controller
    {
        private readonly BuildingStatusApiController _buildingStatusApiController;

        public BuildingStatusController(BuildingStatusApiController buildingStatusApiController)
        {
            _buildingStatusApiController = buildingStatusApiController;
        }

        public ActionResult Index()
        {            
            return View("Index");
        }
        public ActionResult CreateBuildingStatus()
        {
            return ViewComponent("BuildingStatus");
        }

        [HttpPost]
        public async Task<ActionResult> CreateBuildingStatus(BuildingStatusDto buildingStatusDto)
        {
            ViewBag.AddCountMessage = await _buildingStatusApiController.AddBuildingStatusAsync(buildingStatusDto);
            return RedirectToAction("Index");
        }
    }
}
