using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Flats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Interfaces.Services.Flats
{
    public interface IFlatTypeCrudService
    {
        public Task<int> CreateFlatTypeAsync(FlatTypeDto flatStatusDto);
        public Task<FlatTypeDto> GetFlatTypeByIdAsync(Guid id);
        public Task<List<FlatTypeDto>> GetListFlatTypeAsync();
    }
}
