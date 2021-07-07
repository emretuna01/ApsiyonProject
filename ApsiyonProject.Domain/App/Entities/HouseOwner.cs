using ApsiyonProject.Domain.App.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Domain.App.Entities
{
    //User
    public class HouseOwner : BaseEntity
    {
        public string Username{ get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string TCNo { get; set; }
        public string Phone { get; set; }

        public Guid? AdministratorId { get; set; }
        [ForeignKey("AdministratorId")]
        public HouseOwner Administrator { get; set; }

        public ICollection<Flat> Flats { get; set; }
        public ICollection<Car> Cars{ get; set; }
        public ICollection<HouseOwnerRoles> HouseOwnerRoles { get; set; }


    }
}
