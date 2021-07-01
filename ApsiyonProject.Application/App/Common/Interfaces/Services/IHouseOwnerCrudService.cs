using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Interfaces.Services
{
    public interface IHouseOwnerCrudService
    {
        public  Task<int> AddAsync(HouseOwnerDto entity);
    }
}
