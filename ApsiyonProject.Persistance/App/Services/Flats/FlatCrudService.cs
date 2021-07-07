using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Flats;
using ApsiyonProject.Application.App.Common.Interfaces.Services.Buildings;
using ApsiyonProject.Application.App.Common.Interfaces.Services.Flats;
using ApsiyonProject.Application.App.Common.Interfaces.UnitOfWork;
using ApsiyonProject.Domain.App.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Persistance.App.Services.Flats
{
    public class FlatCrudService: IFlatCrudService
    {
        private readonly IBuildingCrudService _buildingCrudService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public FlatCrudService(IUnitOfWork unitOfWork, IMapper mapper, IBuildingCrudService buildingCrudService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _buildingCrudService = buildingCrudService;
        }

        public async Task<int> CreateFlatTypeAsync(FlatDto flatDto)
        {
            var mappedData = _mapper.Map<Flat>(flatDto);
            await _unitOfWork.Flat.AddTypeAsync(mappedData);
            return await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<FlatDto>> GetFlatListByIdWithInculeListAsync(Guid id)
        {
            var dataFromDb = await _buildingCrudService.GetRawBuildingListByIdWithInculeListAsync(id);
            return _mapper.Map<List<FlatDto>>(dataFromDb.SelectMany<Building, Floor>(p => p.Floors).ToList().SelectMany<Floor,Flat>(z => z.Flats).ToList());
            
        }
    }
}
