using ApsiyonProject.Domain.App.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Domain.App.Entities
{
    public class Car : BaseEntity
    {
        public string  Plates { get; set; }

        public Guid? HouseOwnerId { get; set; }
        [ForeignKey("HouseOwnerId")]
        public HouseOwner HouseOwner { get; set; }
    }
}
