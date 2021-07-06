using ApsiyonProject.Domain.App.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Domain.App.Entities
{
    public class Floor : BaseEntity
    {
        public string FloorNumber { get; set; }
        public Guid BuildingId { get; set; }
        [ForeignKey("BuildingId")]
        public Building Building { get; set; }
        public ICollection<Flat>  Flats { get; set; }
    }
}
