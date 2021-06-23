using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Domain.App.Entities
{
    public class Building
    {
        public string BlockName { get; set; }
        public BuildingStatus BuildingStatus { get; set; }
        public BuildingType BuildingType{ get; set; }
        public ICollection<Floor> Floors { get; set; }

    }
}
