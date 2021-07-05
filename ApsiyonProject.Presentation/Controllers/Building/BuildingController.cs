using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Infrastructure.Controllers.Building;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.Controllers.Building
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
        public async Task<ActionResult> AddBuilding(BuildingDto buildingDto)
        {
            ViewBag.AddCountMessage = await _buildingApiController.AddBuildingAsync(buildingDto);
            return RedirectToAction("");
        }

        #region eski
        /*
        public ActionResult Index()
        {
            return View("Index");
        }

        public  ActionResult GetBuildingList()
        {
            return ViewComponent("GetBuildingList");
        }



 
        */
        #endregion
    }
}
