using ApsiyonProject.Application.App.Common.Interfaces.Dtos.HouseOwners;
using ApsiyonProject.Infrastructure.Controllers.Account;
using ApsiyonProject.Presentation.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.ViewComponents.HouseOwners
{
    public class AddUserFromAdministratorViewComponent:ViewComponent
    {
        
        private readonly HouseOwnerDto _houseOwnerDto;
        public AddUserFromAdministratorViewComponent(HouseOwnerDto houseOwnerDto)
        {            
            _houseOwnerDto = houseOwnerDto;
        }

        public IViewComponentResult Invoke()
        {
            _houseOwnerDto.AdministratorId= HttpContext.Session.GetSessionType<Guid>("UserId");
            return View(_houseOwnerDto);   

        }


            
    }
}
