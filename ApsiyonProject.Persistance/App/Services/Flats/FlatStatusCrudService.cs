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
    public class FlatStatusCrudService : IFlatStatusCrudService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FlatStatusCrudService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> CreateFlatStatusAsync(FlatStatusDto entity)
        {
            var mappedData = _mapper.Map<FlatStatus>(entity);
            await _unitOfWork.FlatStatus.AddTypeAsync(mappedData);
            return await _unitOfWork.SaveChangesAsync();
        }

        public async Task<FlatStatusDto> GetFlatStatusByIdAsync(Guid id)
        {
            var preMappedData = await _unitOfWork.FlatStatus.GetWhereAsync(id);
            return _mapper.Map<FlatStatusDto>(preMappedData);
        }

        public async Task<List<FlatStatusDto>> GetListFlatStatusAsync()
        {
            var preMappedData = await _unitOfWork.FlatStatus.GetListAsync();
            return _mapper.Map<List<FlatStatusDto>>(preMappedData);
        }
    }
}
