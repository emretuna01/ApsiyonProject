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
    public class FlatTypeApiController : ControllerBase
    {
        private readonly IFlatTypeCrudService _flatTypeCrudService;

        public FlatTypeApiController(IFlatTypeCrudService flatTypeCrudService)
        {
            _flatTypeCrudService = flatTypeCrudService;
        }
       
        [HttpPost("AddFlatType")]
        public async Task<int> AddFlatTypeAsync(FlatTypeDto flatTypeDto)
        {
            return await _flatTypeCrudService.CreateFlatTypeAsync(flatTypeDto);
        }

        [HttpGet("GetFlatTypeById")]
        public async Task<FlatTypeDto> GetFlatTypeByIdAsync(Guid id)
        {
            return await _flatTypeCrudService.GetFlatTypeByIdAsync(id);
        }

        [HttpGet("GetListFlatType")]
        public async Task<List<FlatTypeDto>> GetListFlatTypeAsync()
        {
            return await _flatTypeCrudService.GetListFlatTypeAsync();
        }

    }
}
