using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Application.App.Common.Interfaces.Services;
using ApsiyonProject.Application.App.Common.Interfaces.UnitOfWork;
using ApsiyonProject.Domain.App.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Persistance.App.Services
{
    public class BuildingStatusCrudService : IBuildingStatusCrudService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BuildingStatusCrudService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> CreateListBuildingStatusAsync(BuildingStatusDto entity)
        {
            var mappedData = _mapper.Map<BuildingStatus>(entity);
            await _unitOfWork.BuildingStatus.AddTypeAsync(mappedData);            
            return await _unitOfWork.SaveChangesAsync();
            
        }

        public async Task<BuildingStatusDto> GetBuildingStatusByIdAsync(Guid id)
        {
            var preMappedData = await _unitOfWork.BuildingStatus.GetWhereAsync(id);
            return _mapper.Map<BuildingStatusDto>(preMappedData);
        }

        public async Task<List<BuildingStatusDto>> GetListBuildingStatusAsync()
        {
            var preMappedData = await _unitOfWork.BuildingStatus.GetListAsync();
            return _mapper.Map<List<BuildingStatusDto>>(preMappedData);
        }
    }
}
