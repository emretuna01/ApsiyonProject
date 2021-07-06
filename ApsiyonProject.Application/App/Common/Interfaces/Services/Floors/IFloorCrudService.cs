using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Floors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Interfaces.Services.Floors
{
    public interface IFloorCrudService
    {
        public Task<int> CreateFloorTypeAsync(FloorDto floorDto);
    }
}
