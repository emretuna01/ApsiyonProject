using ApsiyonProject.Domain.App.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Domain.App.Entities
{
    public class Building : BaseEntity
    {
        public string BlockName { get; set; }
       
        public Guid? BuildingStatusId { get; set; }
        [ForeignKey("BuildingStatusId")]
        public BuildingStatus BuildingStatus { get; set; }        
        
        public Guid? BuildingTypeId { get; set; }
        [ForeignKey("BuildingTypeId")]
        public BuildingType BuildingType{ get; set; }
       
        public ICollection<Floor> Floors { get; set; }
        
        public Guid? AdministratorId { get; set; }
        [ForeignKey("AdministratorId")]        
        public HouseOwner Administrator { get; set; }
    }
}
