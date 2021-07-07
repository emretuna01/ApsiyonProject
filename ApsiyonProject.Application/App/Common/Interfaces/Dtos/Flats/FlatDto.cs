using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Floors;
using ApsiyonProject.Application.App.Common.Interfaces.Dtos.HouseOwners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Interfaces.Dtos.Flats
{
    public class FlatDto
    {
        public Guid Id { get; set; }
        public string FlatNumer { get; set; }
        public Guid FloorId { get; set; }
        public FloorDto Floor { get; set; }

        public Guid FlatStatusId { get; set; }        
        public FlatStatusDto FlatStatus { get; set; }

        public Guid FlatTypeId { get; set; }       
        public FlatTypeDto FlatType { get; set; }

        public Guid HouseOwnerId { get; set; }
        public HouseOwnerDto HouseOwner { get; set; }

        public DateTime CreatedDateTime { get; set; }
        public bool IsActive { get; set; }
    }
}
