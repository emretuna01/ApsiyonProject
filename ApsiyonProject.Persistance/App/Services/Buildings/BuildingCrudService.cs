using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Buildings;
using ApsiyonProject.Application.App.Common.Interfaces.Services;
using ApsiyonProject.Application.App.Common.Interfaces.Services.Buildings;
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
        

        public BuildingCrudService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            
        }

        public async Task<int> AddAsync(AddBuildingDto entity)
        {            
            var mappedData = _mapper.Map<Building>(entity);
            await _unitOfWork.Building.AddTypeAsync(mappedData);
            return await _unitOfWork.SaveChangesAsync();        
        }

        /*
        public async Task<BuildingDto> GetBuildingByIdAsync(Guid id)
        {
            var preMappedData = await _unitOfWork.Building.GetWhereAsync(id);
            return _mapper.Map<BuildingDto>(preMappedData);
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
        */

    }
}
