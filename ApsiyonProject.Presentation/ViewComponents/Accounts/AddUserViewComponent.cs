using ApsiyonProject.Application.App.Common.Interfaces.Dtos.HouseOwners;
using ApsiyonProject.Infrastructure.Controllers.Account;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.ViewComponents.Accounts
{
    public class AddUserViewComponent : ViewComponent
    {
        private readonly HouseOwnerInitDto _houseOwnerInitDto;
        public AddUserViewComponent(HouseOwnerInitDto houseOwnerInitDto)
        {
            _houseOwnerInitDto = houseOwnerInitDto;
        }
        public IViewComponentResult Invoke()
        {
            return View(_houseOwnerInitDto);
        }
    }
}
