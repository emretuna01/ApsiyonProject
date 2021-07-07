using ApsiyonProject.Infrastructure.Controllers.Account;
using ApsiyonProject.Presentation.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.ViewComponents.HouseOwners
{
    public class GetHouseOwnerListByIdViewComponent : ViewComponent
    {
        private readonly HouseOwnerApiController _houseOwnerApiController;
        public GetHouseOwnerListByIdViewComponent(HouseOwnerApiController houseOwnerApiController)
        {
            _houseOwnerApiController = houseOwnerApiController;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userIdFromSession = HttpContext.Session.GetSessionType<Guid>("UserId");
            return View(await _houseOwnerApiController.GetHouseOwnerListByIdWithInculeListAsync(userIdFromSession));
        }

    }
}
