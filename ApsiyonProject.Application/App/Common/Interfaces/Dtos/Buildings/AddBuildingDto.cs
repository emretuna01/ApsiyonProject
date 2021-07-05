using ApsiyonProject.Domain.App.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Interfaces.Dtos.Buildings
{
    public class AddBuildingDto 
    {
        public string BlockName { get; set; }
        public Guid BuildingStatusId { get; set; }
        public Guid BuildingTypeId { get; set; }
        public Guid AdministratorId { get; set; }

    }
}
