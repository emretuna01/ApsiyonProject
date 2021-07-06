using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Buildings;
using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Flats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Interfaces.Dtos.Floors
{
    public class FloorDto
    {
        public Guid Id { get; set; }
        public string FloorNumber { get; set; }
        public Guid BuildingId { get; set; }
        public AddBuildingDto Building { get; set; }               
        
    }
}
