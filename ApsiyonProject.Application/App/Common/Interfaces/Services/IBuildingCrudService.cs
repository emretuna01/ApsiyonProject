using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Building;
using ApsiyonProject.Domain.App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Interfaces.Services
{
    public interface IBuildingCrudService
    {
        public Task<int> AddAsync(AddBuildingDto entity);
       // public Task<List<BuildingDto>> GetListIncludeAsync();
      //  public Task<BuildingDto> GetBuildingByIdAsync(Guid id);
     //   public Task<List<Building>> GetRawListIncludeAsync();

        //void Delete(int id);
        //void Update(BuildingDto entity);
        //Task<List<BuildingDto>> GetAll();
        //Task<List<BuildingDto>> Get(Expression<Func<BuildingDto, bool>> filter);
    }
}
