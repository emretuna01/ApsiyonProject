using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Flats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Interfaces.Services.Flats
{
    public interface IFlatStatusCrudService
    {
        public Task<int> CreateFlatStatusAsync(FlatStatusDto flatStatusDto);
        public Task<FlatStatusDto> GetFlatStatusByIdAsync(Guid id);
        public Task<List<FlatStatusDto>> GetListFlatStatusAsync();
    }
}
