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

        public async Task<int> CreateBuildingAsync(AddBuildingDto entity)
        {
            var mappedData = _mapper.Map<Building>(entity);
            await _unitOfWork.Building.AddTypeAsync(mappedData);
            return await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<GetBuildingListDto>> GetBuildingListByIdWithInculeListAsync(Guid id)
        {
            var preMappedData = await _unitOfWork.Building.GetBuildingListByIdWithInculeListAsync(id);
            return _mapper.Map<List<GetBuildingListDto>>(preMappedData);
        }

        public async Task<List<Building>> GetRawBuildingListByIdWithInculeListAsync(Guid id)
        {
            return  await _unitOfWork.Building.GetBuildingListByIdWithInculeListAsync(id);            
        }


        public async Task<List<Guid>> GetListBuildingHasFloorByIdAsync(Guid id)
        {
            return (await _unitOfWork.Building.GetBuildingListByIdWithInculeListAsync(id)).Where(p => p.Floors.Count > 0).Select(p => p.Id).ToList();
        }


    }
}
