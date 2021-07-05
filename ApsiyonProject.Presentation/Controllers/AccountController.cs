using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Infrastructure.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApsiyonController _apsiyonController;
        public AccountController(ApsiyonController apsiyonController)
        {
            _apsiyonController = apsiyonController;
        }

        public async Task<ActionResult> Index()
        {
            return View(await _apsiyonController.GetListIncludeBuildingAsync());
        }
              

    }
}
