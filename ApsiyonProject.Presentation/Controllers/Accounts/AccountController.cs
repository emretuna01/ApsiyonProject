using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Application.App.Common.Interfaces.Dtos.HouseOwners;
using ApsiyonProject.Infrastructure.Controllers;
using ApsiyonProject.Infrastructure.Controllers.Account;
using ApsiyonProject.Presentation.Extensions;
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
        public async Task<ActionResult> LoginUser(LoginUserDto loginUserDto)
        {
           var userModel= await _houseOwnerApiController.GetHouseOwnerByModel(loginUserDto);
            if (userModel != null )
            {
                if (userModel.Id != Guid.Empty)
                {
                    HttpContext.Session.SetSessionType<Guid>("UserId", userModel.Id);
                    return RedirectToAction("Index");
                    
                }
                else
                {
                    ViewBag.Message = "Yanlış Kullanıcı Adı ya da Şifre";
                    return RedirectToAction("ResponseIndex", new { message = ViewBag.Message });
                }
            }
            else
            {
                ViewBag.Message = "Yanlış Kullanıcı Adı ya da Şifre";
                return RedirectToAction("ResponseIndex", new { message = ViewBag.Message });
            }
            
        }

        public ActionResult AddUserFromAdministrator(HouseOwnerDto houseOwnerDto)
        {
            houseOwnerDto.AdministratorId= HttpContext.Session.GetSessionType<Guid>("UserId");
            return View(houseOwnerDto);
        }

        [HttpPost]
        public async Task<ActionResult> AddUserFromAdministratorWithPost(HouseOwnerDto houseOwnerDto)
        {           
            await _houseOwnerApiController.AddHouseOwnerByAdministrator(houseOwnerDto);
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
