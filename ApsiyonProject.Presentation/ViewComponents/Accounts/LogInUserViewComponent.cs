using ApsiyonProject.Application.App.Common.Interfaces.Dtos.HouseOwners;
using ApsiyonProject.Infrastructure.Controllers.Account;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.ViewComponents.Accounts
{
    public class LogInUserViewComponent : ViewComponent
    {
        private readonly LoginUserDto _loginUserDto;
        public LogInUserViewComponent(LoginUserDto loginUserDto)
        {            
            _loginUserDto = loginUserDto;
        }
        public IViewComponentResult Invoke()
        {
            return View(_loginUserDto);
        }
    }
}
