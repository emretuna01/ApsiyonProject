using ApsiyonProject.Domain.App.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Domain.App.Entities
{
    public class Floor : BaseEntitiy
    {
        public string FloorNumber { get; set; }
        public Building Building { get; set; }
        public ICollection<Flat>  Flats { get; set; }
    }
}
