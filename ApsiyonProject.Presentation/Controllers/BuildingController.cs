using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.Controllers
{
    public class BuildingController : Controller
    {
        public async Task<ActionResult> GetBuildingList()
        {
            return PartialView(await _apsiyonController.GetListIncludeBuildingAsync());
        }

        public ActionResult CreateBuilding()
        {
            // ViewBag.BuildingStatus = await _apsiyonController.GetListBuildingStatusAsync();
            return ViewComponent("Building");
        }

        [HttpPost]
        public async Task<ActionResult> CreateBuilding(BuildingDto buildingDto)
        {
            ViewBag.AddCountMessage = await _apsiyonController.AddBuildingAsync(buildingDto);
            return RedirectToAction("Index");
        }

    }
}
