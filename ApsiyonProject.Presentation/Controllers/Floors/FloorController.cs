using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Floors;
using ApsiyonProject.Infrastructure.Controllers.Floors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.Controllers.Floors
{
    public class FloorController : Controller
    {
        private readonly FloorApiController _floorApiController;
        private readonly FloorDto _floorDto;

        public FloorController(FloorApiController floorApiController, FloorDto floorDto)
        {
            _floorApiController = floorApiController;
            _floorDto = floorDto;
        }

        public ActionResult AddFloor([FromQuery] string buildingId)
        {
            _floorDto.BuildingId = Guid.Parse(buildingId);
            return View(_floorDto);
        }

        [HttpPost]
        public async Task<ActionResult> AddFloor(FloorDto floorDto)
        {           
           ViewBag.AddCountMessage=await _floorApiController.AddFloorAsync(floorDto);
           return RedirectToAction("Index", "Account");
        }

      
    }
}
