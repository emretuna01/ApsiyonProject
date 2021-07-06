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
        public AddBuildingDto Building { get; set; }
        public ICollection<FlatDto> Flats { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public bool IsActive { get; set; }
    }
}
