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
    public class BuildingCrudService : IBuildingCrudService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IBuildingStatusCrudService _buildingStatusCrudService;

        public BuildingCrudService(IMapper mapper, IUnitOfWork unitOfWork, IBuildingStatusCrudService buildingStatusCrudService)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _buildingStatusCrudService = buildingStatusCrudService;
        }
        public async Task<int> AddAsync(BuildingDto entity)
        {
            entity.BuildingStatus= await _buildingStatusCrudService.GetBuildingStatusByIdAsync(entity.BuildingStatusId);            
            var mappedData = _mapper.Map<Building>(entity);
            await _unitOfWork.Building.AddTypeAsync(mappedData);
            return await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<BuildingDto>> GetListIncludeAsync()
        {
            var preMappedData=  await _unitOfWork.Building.GetBuildingsIncludeAsync();
            return _mapper.Map<List<BuildingDto>>(preMappedData);
        }


    }
}
