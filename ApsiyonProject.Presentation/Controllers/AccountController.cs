using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Infrastructure.Controllers;
using ApsiyonProject.Infrastructure.Controllers.Account;
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
        private readonly HouseOwnerApiController _houseOwnerApiController;
        public AccountController(HouseOwnerApiController houseOwnerApiController)
        {            
            _houseOwnerApiController = houseOwnerApiController;
        }

     
              

    }
}
