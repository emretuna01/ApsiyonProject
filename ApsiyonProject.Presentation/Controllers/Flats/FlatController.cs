using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Flats;
using ApsiyonProject.Infrastructure.Controllers.Account;
using ApsiyonProject.Infrastructure.Controllers.Flats;
using ApsiyonProject.Presentation.Extensions;
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
        private readonly FlatStatusApiController _flatStatusApiController;
        private readonly FlatTypeApiController _flatTypeApiController;
        private readonly FlatDto _flatDto;
        private readonly HouseOwnerApiController _houseOwnerApiController;

        public FlatController(FlatApiController flatApiController, FlatDto flatDto, FlatStatusApiController flatStatusApiController, FlatTypeApiController flatTypeApiController, HouseOwnerApiController houseOwnerApiController)
        {
            _flatApiController = flatApiController;
            _flatDto = flatDto;
            _flatStatusApiController = flatStatusApiController;
            _flatTypeApiController = flatTypeApiController;
            _houseOwnerApiController = houseOwnerApiController;
        }

        public async Task<ActionResult> AddFlat([FromQuery] string floorId)
        {
            _flatDto.FloorId= Guid.Parse(floorId);
            ViewBag.FlatStatus = await _flatStatusApiController.GetListFlatStatusAsync();
            ViewBag.FlatType = await _flatTypeApiController.GetListFlatTypeAsync();
            var userIdFromSession = HttpContext.Session.GetSessionType<Guid>("UserId");
            ViewBag.HouseOwner = await _houseOwnerApiController.GetHouseOwnerListByIdWithInculeListAsync(userIdFromSession);
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
