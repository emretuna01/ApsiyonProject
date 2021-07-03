using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Infrastructure.Controllers;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.ViewComponents
{
    public class GetBuildingListViewComponent : ViewComponent
    {
        private readonly ApsiyonController _apsiyonController;
        private readonly DefaultBuildingDto _defaultBuildingDto;
        private readonly IMapper _mapper;
        public GetBuildingListViewComponent(ApsiyonController apsiyonController, BuildingDto buildingDto, DefaultBuildingDto defaultBuildingDto, IMapper mapper)
        {
            _apsiyonController = apsiyonController;
            _defaultBuildingDto = defaultBuildingDto;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {            
            var mappedData=_mapper.Map<IEnumerable<DefaultBuildingDto>>(await _apsiyonController.GetRawListIncludeBuildingAsync());            
            return View(mappedData);
        }
    }
}
