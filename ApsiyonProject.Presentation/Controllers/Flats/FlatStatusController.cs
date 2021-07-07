using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.Controllers.Flats
{
    public class FlatStatusController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
