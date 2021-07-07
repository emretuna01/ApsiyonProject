using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Flats;
using ApsiyonProject.Infrastructure.Controllers.Flats;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.Controllers.Flats
{
    public class FlatController : Controller
    {
        private readonly FlatApiController _flatApiController;
        private readonly FlatDto _flatDto;

        public FlatController(FlatApiController flatApiController, FlatDto flatDto)
        {
            _flatApiController = flatApiController;
            _flatDto = flatDto;
        }

        public ActionResult AddFlat([FromQuery] string floorId)
        {
            _flatDto.FloorId= Guid.Parse(floorId);
            return View(_flatDto);
        }

        [HttpPost]
        public async Task<ActionResult> AddFlat(FlatDto flatDto)
        {
            ViewBag.AddCountMessage = await _flatApiController.AddFlatAsync(flatDto);
            return RedirectToAction("Index", "Account");
        }


    }
}
