using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Floors;
using ApsiyonProject.Application.App.Common.Interfaces.Services.Floors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Infrastructure.Controllers.Floors
{
    [Route("api/[controller]")]
    [ApiController]
    public class FloorApiController : ControllerBase
    {
        private readonly IFloorCrudService _floorCrudService;

        public FloorApiController(IFloorCrudService floorCrudService)
        {
            _floorCrudService = floorCrudService;
        }

        [HttpPost("AddFloor")]
        public async Task<int> AddFloorAsync(FloorDto floorDto)
        {
            return await _floorCrudService.CreateFloorTypeAsync(floorDto);
        }
    }
}
