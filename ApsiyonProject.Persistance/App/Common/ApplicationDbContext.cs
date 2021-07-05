using ApsiyonProject.Application.App.Common.Interfaces.DbContext;
using ApsiyonProject.Domain.App.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Persistance.App.Common
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {

        }

        public DbSet<Building> Buildings { get; set; }
        public DbSet<BuildingStatus> BuildingStatuses { get; set; }
        public DbSet<BuildingType> BuildingTypes { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Flat> Flats  { get; set; }
        public DbSet<FlatType> FlatTypes { get; set; }
        public DbSet<FlatStatus> FlatStatuses{ get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<HouseOwner> HouseOwners { get; set; }
        public DbSet<HouseOwnerRoleClaims> HouseOwnerRoleClaims { get; set; }
        public DbSet<HouseOwnerRoles> HouseOwnerRoles { get; set; }

    }
}
