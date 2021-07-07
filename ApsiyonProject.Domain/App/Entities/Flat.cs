using ApsiyonProject.Domain.App.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Domain.App.Entities
{
    public class Flat : BaseEntity
    {
        public string FlatNumer { get; set; }

        public Guid FloorId { get; set; }
        [ForeignKey("FloorId")]
        public Floor Floor { get; set; }

        
        public Guid HouseOwnerId { get; set; }
        [ForeignKey("HouseOwnerId")]
        public HouseOwner HouseOwner { get; set; }

        public Guid FlatStatusId { get; set; }
        [ForeignKey("FlatStatusId")]
        public FlatStatus FlatStatus { get; set; }
        
        public Guid FlatTypeId { get; set; }
        [ForeignKey("FlatTypeId")]
        public FlatType FlatType { get; set; }
    }
}
