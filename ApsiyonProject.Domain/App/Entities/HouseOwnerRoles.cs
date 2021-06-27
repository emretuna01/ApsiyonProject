using ApsiyonProject.Domain.App.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Domain.App.Entities
{
    //grup
    public class HouseOwnerRoles:BaseEntity
    {
        public ICollection<HouseOwnerRoleClaims> HouseOwnerRoleClaims { get; set; }
        public ICollection<HouseOwner> HouseOwners { get; set; }
    }
}
