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


        public async Task<BuildingDto> GetBuildingByIdAsync(Guid id)
        {
            var preMappedData = await _unitOfWork.Building.GetWhereAsync(id);
            return _mapper.Map<BuildingDto>(preMappedData);
        }

        public async Task<int> AddAsync(BuildingDto entity)
        {
            var buildingStatusId = entity.BuildingStatusId;
            var mappedData = _mapper.Map<Building>(entity);            
            var preInsertData = await _unitOfWork.Building.AddTypeWithReturnAsync(mappedData);
            var countInsertedData = await _unitOfWork.SaveChangesAsync();
            if (countInsertedData>0)
            {
                var dbData=await GetBuildingByIdAsync(preInsertData.Entity.Id);
                var buildingStatusData = await _buildingStatusCrudService.GetBuildingStatusByIdAsync(buildingStatusId);
                dbData.BuildingStatus = buildingStatusData;
                var firstmapped = _mapper.Map<BuildingUpdateDto>(dbData);
                var secondmapped= _mapper.Map<Building>(firstmapped);
                return await _unitOfWork.Building.CustomUpdate(secondmapped);                
            }
            return 0;
        }


        public async Task<List<BuildingDto>> GetListIncludeAsync()
        {
            var preMappedData = await _unitOfWork.Building.GetBuildingsIncludeAsync();
            return _mapper.Map<List<BuildingDto>>(preMappedData);
        }
        public async Task<List<Building>> GetRawListIncludeAsync()
        {
            return await _unitOfWork.Building.GetBuildingsIncludeAsync();            
        }


    }
}
