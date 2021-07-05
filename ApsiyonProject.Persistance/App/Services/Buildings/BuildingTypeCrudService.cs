using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Buildings;
using ApsiyonProject.Application.App.Common.Interfaces.Services;
using ApsiyonProject.Application.App.Common.Interfaces.Services.Buildings;
using ApsiyonProject.Application.App.Common.Interfaces.UnitOfWork;
using ApsiyonProject.Domain.App.Entities;
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

        public async Task<int> CreateBuildingTypeAsync(BuildingTypeDto entity)
        {
            var mappedData = _mapper.Map<BuildingType>(entity);
            await _unitOfWork.BuildingType.AddTypeAsync(mappedData);
            return await _unitOfWork.SaveChangesAsync();

        }

        public async Task<BuildingTypeDto> GetBuildingTypeByIdAsync(Guid id)
        {
            var preMappedData = await _unitOfWork.BuildingType.GetWhereAsync(id);
            return _mapper.Map<BuildingTypeDto>(preMappedData);
        }

        public async Task<List<BuildingTypeDto>> GetListBuildingTypeAsync()
        {
            var preMappedData = await _unitOfWork.BuildingType.GetListAsync();
            return _mapper.Map<List<BuildingTypeDto>>(preMappedData);
        }

    }
}
