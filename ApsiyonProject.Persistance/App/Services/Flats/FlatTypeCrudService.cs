using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Flats;
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
    public class FlatTypeCrudService : IFlatTypeCrudService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FlatTypeCrudService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> CreateFlatTypeAsync(FlatTypeDto entity)
        {
            var mappedData = _mapper.Map<FlatType>(entity);
            await _unitOfWork.FlatType.AddTypeAsync(mappedData);
            return await _unitOfWork.SaveChangesAsync();
        }

        public async Task<FlatTypeDto> GetFlatTypeByIdAsync(Guid id)
        {
            var preMappedData = await _unitOfWork.FlatType.GetWhereAsync(id);
            return _mapper.Map<FlatTypeDto>(preMappedData);
        }

        public async Task<List<FlatTypeDto>> GetListFlatTypeAsync()
        {
            var preMappedData = await _unitOfWork.FlatType.GetListAsync();
            return _mapper.Map<List<FlatTypeDto>>(preMappedData);
        }
    }
}
