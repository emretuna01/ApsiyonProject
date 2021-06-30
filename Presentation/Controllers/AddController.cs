using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Infrastructure.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    public class AddController : Controller
    {
        private readonly ApsiyonController _apsiyonController;
       // private readonly BuildingDto _buildingDto;

        public AddController(ApsiyonController apsiyonController, BuildingDto buildingDto)
        {
            _apsiyonController = apsiyonController;
           // _buildingDto = buildingDto;
        }
        [HttpGet]
        public IActionResult AddBuilding()
        {   
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBuilding(BuildingDto buildingDto)
        {
            await _apsiyonController.AddBuilding(buildingDto);
            return View();
        }
    }
}
