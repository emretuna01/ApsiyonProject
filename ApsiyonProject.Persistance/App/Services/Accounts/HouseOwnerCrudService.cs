using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Application.App.Common.Interfaces.Dtos.HouseOwners;
using ApsiyonProject.Application.App.Common.Interfaces.Services.Buildings;
using ApsiyonProject.Application.App.Common.Interfaces.Services.HouseOwners;
using ApsiyonProject.Application.App.Common.Interfaces.UnitOfWork;
using ApsiyonProject.Application.App.Common.Profiles.HouseOwners;
using ApsiyonProject.Domain.App.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Persistance.App.Services.Accounts
{
    public class HouseOwnerCrudService : IHouseOwnerCrudService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;        

        public HouseOwnerCrudService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;            
        }

        public async Task<int> CreateHouseOwnerInitTypeAsync(HouseOwnerInitDto entity)
        {
            var mappedData = _mapper.Map<HouseOwner>(entity);
            await _unitOfWork.HouseOwner.AddTypeAsync(mappedData);
            return await _unitOfWork.SaveChangesAsync();
        }

        public async Task<int> CreateHouseOwnerTypeByAdministratorAsync(HouseOwnerDto houseOwnerDto)
        {
            var mappedData = _mapper.Map<HouseOwner>(houseOwnerDto);
            await _unitOfWork.HouseOwner.AddTypeAsync(mappedData);
            return await _unitOfWork.SaveChangesAsync();
        }

        public async Task<LoginUserResponseDto> GetUserByModelAync(LoginUserDto loginUserDto)
        {
            var mappedData = _mapper.Map<HouseOwner>(loginUserDto);
            var dataFromDb= await _unitOfWork.HouseOwner.GetWhereAsync(p=>p.Username.Contains(mappedData.Username) && p.Password.Contains(mappedData.Password));
            return _mapper.Map<LoginUserResponseDto>(dataFromDb);
            
        }

        public async Task<List<HouseOwnerDto>> GetHouseOwnerListByIdWithInculeListAsync(Guid id)
        {
            var preMappedData= await _unitOfWork.HouseOwner.GetWhereListAsync(p => p.AdministratorId == id);
            return _mapper.Map<List<HouseOwnerDto>>(preMappedData);
                
        }

    }
}
