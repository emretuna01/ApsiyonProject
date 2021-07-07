using ApsiyonProject.Infrastructure.Controllers.Flats;
using ApsiyonProject.Presentation.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.ViewComponents.Flats
{
    public class GetFlatListByIdViewComponent : ViewComponent
    {
        private readonly FlatApiController _flatApiController;
        public GetFlatListByIdViewComponent(FlatApiController flatApiController)
        {
            _flatApiController = flatApiController;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userIdFromSession = HttpContext.Session.GetSessionType<Guid>("UserId");
            return View(await _flatApiController.GetFlatListByIdWithInculeListAsync(userIdFromSession));
        }
    }
}
