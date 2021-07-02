using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Interfaces.Dtos
{
    public class CarDto
    {
        public Guid Id { get; set; }
        public string Plates { get; set; }
        public HouseOwnerDto HouseOwner { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public bool IsActive { get; set; }
    }
}
