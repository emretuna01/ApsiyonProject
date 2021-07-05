using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Application.App.Common.Interfaces.Dtos.HouseOwners;
using ApsiyonProject.Application.App.Common.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Infrastructure.Controllers.Account
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseOwnerApiController : ControllerBase
    {
        private readonly IHouseOwnerCrudService _houseOwnerCrudService;
        public HouseOwnerApiController(IHouseOwnerCrudService houseOwnerCrudService)
        {
            _houseOwnerCrudService = houseOwnerCrudService;

        }

        [HttpPost("AddHouseOwner")]
        public async Task<int> AddHouseOwner(HouseOwnerInitDto houseOwnerInitDto)
        {
            return await _houseOwnerCrudService.CreateAsync(houseOwnerInitDto);
        }

        [HttpPost("GetHouseOwnerByModel")]
        public async Task<LoginUserResponseDto> GetHouseOwnerByModel(LoginUserDto loginUserDto)
        {
            return  await _houseOwnerCrudService.GetUserByModelAync(loginUserDto);
        }
    }
}
