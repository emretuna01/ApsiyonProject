using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Interfaces.Dtos
{
    public class FlatDto
    {
        public string FlatNumer { get; set; }
        public FloorDto Floor { get; set; }
        public HouseOwnerDto HouseOwner { get; set; }
    }
}
