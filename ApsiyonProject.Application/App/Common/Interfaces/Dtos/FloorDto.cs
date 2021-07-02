using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Interfaces.Dtos
{
    public class FloorDto
    {
        public string FloorNumber { get; set; }
        public BuildingDto Building { get; set; }
        public ICollection<FlatDto> Flats { get; set; }
    }
}
