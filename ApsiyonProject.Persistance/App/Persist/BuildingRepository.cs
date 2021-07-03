﻿using ApsiyonProject.Application.App.Common.Interfaces.DbRepository;
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

        public async Task<List<Building>> GetBuildingsIncludeAsync()
        {
           return  await _building
                .Include(p => p.BuildingStatus)
                .Include(p => p.BuildingType)
                .Include(p => p.Floors)
                .ThenInclude(p => p.Flats)
                .ThenInclude(p => p.HouseOwner).ToListAsync();
        }

        public async Task<int> CustomUpdate(Building building)
        {
            string preUpdatedValue = building.BuildingStatus.Id.ToString();
            string dbRowId = building.Id.ToString();
            string sqlString = $"UPDATE [ApsiyonProject].[dbo].[Buildings] SET BuildingStatusId = cast('{preUpdatedValue}' AS UNIQUEIDENTIFIER) WHERE[dbo].[Buildings].[Id] = cast('{dbRowId}' AS UNIQUEIDENTIFIER)";
            return await _aplicationDbContext.Database.ExecuteSqlRawAsync(sqlString);
        }

    }
}
