using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Buildings;
using ApsiyonProject.Domain.App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Interfaces.Services.Buildings
{
    public interface IBuildingCrudService
    {
        public Task<int> CreateBuildingAsync(AddBuildingDto entity);
        public Task<List<GetBuildingListDto>> GetBuildingListByIdWithInculeListAsync(Guid id);

    }
}
