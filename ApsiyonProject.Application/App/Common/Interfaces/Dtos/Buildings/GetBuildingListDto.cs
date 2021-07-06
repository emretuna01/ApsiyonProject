using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Floors;
using ApsiyonProject.Application.App.Common.Interfaces.Dtos.HouseOwners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Interfaces.Dtos.Buildings
{
    public class GetBuildingListDto
    {
        public string BlockName { get; set; }        
        public BuildingStatusDto BuildingStatus { get; set; }               
        public BuildingTypeDto BuildingType { get; set; }     
        public HouseOwnerDto Administrator { get; set; }
    }
}
