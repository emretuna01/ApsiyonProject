using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Application.App.Common.Interfaces.Dtos.HouseOwners;
using ApsiyonProject.Application.App.Common.Profiles.HouseOwners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Interfaces.Services
{
    public interface IHouseOwnerCrudService
    {
        public  Task<int> CreateAsync(HouseOwnerInitDto entity);
        public Task<LoginUserResponseDto> GetUserByModelAync(LoginUserDto loginUserDto);
    }
}
