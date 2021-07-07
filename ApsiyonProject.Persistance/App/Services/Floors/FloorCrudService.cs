using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Floors;
using ApsiyonProject.Application.App.Common.Interfaces.Services.Buildings;
using ApsiyonProject.Application.App.Common.Interfaces.Services.Floors;
using ApsiyonProject.Application.App.Common.Interfaces.UnitOfWork;
using ApsiyonProject.Domain.App.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Persistance.App.Services.Floors
{
    public class FloorCrudService : IFloorCrudService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IBuildingCrudService _buildingCrudService;
        private readonly List<FloorDto> _floorDtos;
        public FloorCrudService(IUnitOfWork unitOfWork, IMapper mapper, IBuildingCrudService buildingCrudService, List<FloorDto> floorDtos)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _buildingCrudService = buildingCrudService;
            _floorDtos = floorDtos;
        }

        public async Task<int> CreateFloorTypeAsync(FloorDto floorDto)
        {
            var mappedData = _mapper.Map<Floor>(floorDto);
            await _unitOfWork.Floor.AddTypeAsync(mappedData);
            return await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<FloorDto>> GetFloorListByIdWithInculeListAsync(Guid id)
        {          
            var dataFromDb = await _buildingCrudService.GetRawBuildingListByIdWithInculeListAsync(id);            
            return _mapper.Map<List<FloorDto>>(dataFromDb.SelectMany<Building, Floor>(p => p.Floors));
            
        }
        
    }






}


 