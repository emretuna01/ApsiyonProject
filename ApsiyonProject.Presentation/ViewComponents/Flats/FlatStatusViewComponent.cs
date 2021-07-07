using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Flats;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.ViewComponents.Flats
{
    public class FlatStatusViewComponent : ViewComponent
    {
        private readonly FlatStatusDto _flatStatusDto;

        public FlatStatusViewComponent(FlatStatusDto flatStatusDto)
        {
            _flatStatusDto = flatStatusDto;
        }

        public IViewComponentResult Invoke()
        {
            return View(_flatStatusDto);
        }
    }
}
