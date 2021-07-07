using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Flats;
using ApsiyonProject.Infrastructure.Controllers.Flats;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.Controllers.Flats
{
    public class FlatTypeController : Controller
    {
        private readonly FlatTypeApiController _flatTypeApiController;

        public FlatTypeController(FlatTypeApiController flatTypeApiController)
        {
            _flatTypeApiController = flatTypeApiController;
        }

        [HttpPost]
        public async Task<ActionResult> AddFlatType(FlatTypeDto flatTypeDto)
        {
            ViewBag.AddCountMessage = await _flatTypeApiController.AddFlatTypeAsync(flatTypeDto);
            return RedirectToAction("Index", "Account");
        }
    }
}
