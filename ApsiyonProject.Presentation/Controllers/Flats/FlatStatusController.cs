using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Flats;
using ApsiyonProject.Infrastructure.Controllers.Flats;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.Controllers.Flats
{
    public class FlatStatusController : Controller
    {
        private readonly FlatStatusApiController _flatStatusApiController;

        public FlatStatusController(FlatStatusApiController flatStatusApiController)
        {
            _flatStatusApiController = flatStatusApiController;
        }
        
        [HttpPost]
        public async Task<ActionResult> AddFlatStatus(FlatStatusDto flatStatusDto)
        {
            ViewBag.AddCountMessage = await _flatStatusApiController.AddFlatStatusAsync(flatStatusDto);
            return RedirectToAction("Index", "Account");
        }
   
    }
}
