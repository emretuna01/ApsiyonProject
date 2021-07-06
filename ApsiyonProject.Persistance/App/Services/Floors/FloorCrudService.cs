using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Floors;
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

        public FloorCrudService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> CreateFloorTypeAsync(FloorDto floorDto)
        {
            var mappedData = _mapper.Map<Floor>(floorDto);
            await _unitOfWork.Floor.AddTypeAsync(mappedData);
            return await _unitOfWork.SaveChangesAsync();
        }
    }
}
