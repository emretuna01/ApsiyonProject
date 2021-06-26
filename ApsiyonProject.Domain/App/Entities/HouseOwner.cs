using ApsiyonProject.Domain.App.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Domain.App.Entities
{
    public class HouseOwner : BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string TCNo { get; set; }
        public string Phone { get; set; }
        public ICollection<Flat> Flats { get; set; }
        public ICollection<Car> Cars{ get; set; }

    }
}
