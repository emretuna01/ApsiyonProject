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
        public string BlockName { get; set; }
        public BuildingStatus BuildingStatus { get; set; }
        public BuildingType BuildingType { get; set; }
       
    }
}
