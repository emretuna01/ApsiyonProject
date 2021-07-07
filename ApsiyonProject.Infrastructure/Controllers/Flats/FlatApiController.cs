using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Flats;
using ApsiyonProject.Application.App.Common.Interfaces.Services.Flats;
using ApsiyonProject.Application.App.Common.Interfaces.Services.Floors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Infrastructure.Controllers.Flats
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlatApiController : ControllerBase
    {
        private readonly IFlatCrudService _flatCrudService;
        public FlatApiController(IFlatCrudService flatCrudService)
        {
            _flatCrudService = flatCrudService;
        }

        [HttpPost("AddFlat")]
        public async Task<int> AddFlatAsync(FlatDto flatDto)
        {
            return await _flatCrudService.CreateFlatTypeAsync(flatDto);
        }

    }
}
