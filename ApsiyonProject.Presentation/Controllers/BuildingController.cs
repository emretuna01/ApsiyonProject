using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Infrastructure.Controllers.Building;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.Controllers
{
    public class BuildingController : Controller
    {
        readonly private BuildingApiController _buildingApiController;

        public BuildingController(BuildingApiController buildingApiController)
        {
            _buildingApiController = buildingApiController;
        }
        public ActionResult Index()
        {
            return View("Index");
        }

        public  ActionResult GetBuildingList()
        {
            return ViewComponent("GetBuildingList");
        }

        public ActionResult CreateBuilding()
        {            
            return ViewComponent("Building");
        }

        [HttpPost]
        public async Task<ActionResult> CreateBuilding(BuildingDto buildingDto)
        {
            ViewBag.AddCountMessage = await _buildingApiController.AddBuildingAsync(buildingDto);
            return RedirectToAction("Index");
        }

    }
}
