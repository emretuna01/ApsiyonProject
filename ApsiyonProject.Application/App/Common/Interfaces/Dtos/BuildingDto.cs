using ApsiyonProject.Domain.App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Interfaces.Dtos
{
    public class BuildingDto
    {
        public Guid Id { get; set; }
        public string BlockName { get; set; }
        public Guid BuildingStatusId { get; set; }
        public Guid BuildingTypeId { get; set; }
        public BuildingStatusDto BuildingStatus { get; set; }
        public BuildingTypeDto BuildingType { get; set; }
        public List<FloorDto> Floors { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public bool IsActive { get; set; }

    }
}
