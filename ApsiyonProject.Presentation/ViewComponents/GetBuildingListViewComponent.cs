using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Infrastructure.Controllers.Building;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.ViewComponents
{
    public class GetBuildingListViewComponent : ViewComponent
    {
        private readonly BuildingApiController _buildingApiController;
        private readonly IMapper _mapper;
        public GetBuildingListViewComponent(BuildingDto buildingDto, IMapper mapper, BuildingApiController buildingApiController)
        {
            _mapper = mapper;
            _buildingApiController = buildingApiController;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var mappedData = _mapper.Map<IEnumerable<DefaultBuildingDto>>(await _buildingApiController.GetRawListIncludeBuildingAsync());
            return View(mappedData);
        }
    }
}
