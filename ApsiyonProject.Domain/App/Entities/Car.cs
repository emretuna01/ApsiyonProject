using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Domain.App.Entities
{
    public class Car
    {
        public string  Plates { get; set; }
        public HouseOwner HouseOwner { get; set; }
    }
}
