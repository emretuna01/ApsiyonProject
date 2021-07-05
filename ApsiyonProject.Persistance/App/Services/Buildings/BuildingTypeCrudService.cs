using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Buildings;
using ApsiyonProject.Application.App.Common.Interfaces.Services;
using ApsiyonProject.Application.App.Common.Interfaces.Services.Buildings;
using ApsiyonProject.Application.App.Common.Interfaces.UnitOfWork;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Persistance.App.Services.Buildings.Buildings
{
    public class BuildingTypeCrudService : IBuildingTypeCrudService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BuildingTypeCrudService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<BuildingTypeDto>> GetListBuildingTypeAsync()
        {
            var preMappedData = await _unitOfWork.BuildingType.GetListAsync();
            return _mapper.Map<List<BuildingTypeDto>>(preMappedData);
        }
    }
}
