using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Flats;
using ApsiyonProject.Application.App.Common.Interfaces.Services.Flats;
using ApsiyonProject.Application.App.Common.Interfaces.UnitOfWork;
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

        public Task<int> CreateFlatTypeAsync(FlatTypeDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<FlatTypeDto> GetFlatTypeByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<FlatTypeDto>> GetListFlatTypeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
