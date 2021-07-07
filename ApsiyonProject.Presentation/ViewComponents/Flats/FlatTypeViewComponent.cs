using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Flats;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.ViewComponents.Flats
{
    public class FlatTypeViewComponent : ViewComponent
    {
        private readonly FlatTypeDto _flatTypeDto;

        public FlatTypeViewComponent(FlatTypeDto flatTypeDto)
        {
            _flatTypeDto = flatTypeDto;
        }

        public IViewComponentResult Invoke()
        {
            return View(_flatTypeDto);
        }
    }
}
