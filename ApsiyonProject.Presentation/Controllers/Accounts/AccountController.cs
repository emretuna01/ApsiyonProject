using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Application.App.Common.Interfaces.Dtos.HouseOwners;
using ApsiyonProject.Infrastructure.Controllers;
using ApsiyonProject.Infrastructure.Controllers.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.Controllers.Accounts
{
    public class AccountController : Controller
    {
        private readonly HouseOwnerApiController _houseOwnerApiController;
        public AccountController(HouseOwnerApiController houseOwnerApiController)
        {            
            _houseOwnerApiController = houseOwnerApiController;
        }

        public ActionResult AddUser()
        {
            return ViewComponent("AddUser");
        }

        [HttpPost]
        public async Task<ActionResult> AddUser(HouseOwnerInitDto houseOwnerInitDto)
        {
            ViewBag.Message = (await _houseOwnerApiController.AddHouseOwner(houseOwnerInitDto)).ToString() + " Kayıt Başarı ile Eklendi";
            return RedirectToAction("ResponseIndex", new { message = ViewBag.Message });
        }
        public ActionResult ResponseIndex(string message)
        {
            ViewBag.Message = message;
            return View("~/Views/Shared/_Response.cshtml");
        }

        public ActionResult LoginUser()
        {
            return ViewComponent("LogInUser");
        }
        
        [HttpPost]
        public ActionResult LoginUser(LoginUserDto loginUserDto)
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }






    }
}
