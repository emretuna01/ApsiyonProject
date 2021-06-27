using ApsiyonProject.Domain.App.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Domain.App.Entities
{
    //Hak
    public class HouseOwnerRoleClaims:BaseEntity
    {
        public ICollection<HouseOwnerRoles> HouseOwnerRoles { get; set; }
    }
}
