using ApsiyonProject.Application.App.Common.Interfaces.DbRepository;
using ApsiyonProject.Domain.App.Entities;
using ApsiyonProject.Persistance.App.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Persistance.App.Persist
{
    public class BuildingRepository : ApplicationDbRepository<Building>, IBuildingRepository
    {
        public DbSet<Building> _building;
        public BuildingRepository(ApplicationDbContext aplicationDbContext) : base(aplicationDbContext)
        {
            _building = aplicationDbContext.Set<Building>();
        }

        public async Task<List<Building>> GetBuildingListByIdWithInculeListAsync(Guid id)
        {
            return await _building
                .Where(p => p.AdministratorId.Equals(id))
                .Include(p => p.Administrator)
                .Include(p => p.BuildingStatus)
                .Include(p => p.BuildingType)
                .Include(p => p.Floors)
                .ThenInclude(p => p.Flats)
                .ThenInclude(p => p.HouseOwner)
                .ThenInclude(p => p.Cars)
                .ToListAsync();

        }

    }
}
