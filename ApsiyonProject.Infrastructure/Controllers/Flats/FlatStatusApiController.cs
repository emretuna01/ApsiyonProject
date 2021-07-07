using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Flats;
using ApsiyonProject.Application.App.Common.Interfaces.Services.Flats;
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
    public class FlatStatusApiController : ControllerBase
    {
        private readonly IFlatStatusCrudService _flatStatusCrudService;
        public FlatStatusApiController(IFlatStatusCrudService flatStatusCrudService)
        {
            _flatStatusCrudService = flatStatusCrudService;
        }

        [HttpPost("AddFlatStatus")]
        public async Task<int> AddFlatStatusAsync(FlatStatusDto flatStatusDto)
        {
            return await _flatStatusCrudService.CreateFlatStatusAsync(flatStatusDto);
        }

        [HttpGet("GetFlatStatusById")]
        public async Task<FlatStatusDto> GetFlatStatusByIdAsync(Guid id)
        {
            return await _flatStatusCrudService.GetFlatStatusByIdAsync(id);
        }

        [HttpGet("GetListFlatStatus")]
        public async Task<List<FlatStatusDto>> GetListFlatStatusAsync()
        {
            return await _flatStatusCrudService.GetListFlatStatusAsync();
        }

    }
}
