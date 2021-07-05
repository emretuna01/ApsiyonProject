using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Interfaces.Dtos.Buildings
{
    public class BuildingStatusDto
    {
        public Guid Id { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public bool IsActive { get; set; }
    }
}
