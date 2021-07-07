using ApsiyonProject.Infrastructure.Controllers.Building;
using ApsiyonProject.Infrastructure.Controllers.Floors;
using ApsiyonProject.Presentation.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.ViewComponents.Floors
{
    
    public class GetFloorListByIdViewComponent : ViewComponent
    {
        private readonly FloorApiController _floorApiController ;

        public GetFloorListByIdViewComponent(FloorApiController floorApiController)
        {
             _floorApiController= floorApiController;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userIdFromSession = HttpContext.Session.GetSessionType<Guid>("UserId");
            return View(await _floorApiController.GetFloorListByIdWithInculeListAsync(userIdFromSession));
        }
    }
    
}
