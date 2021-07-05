﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Interfaces.Dtos
{
    public class HouseOwnerDto
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string TCNo { get; set; }
        public string Phone { get; set; }
        public ICollection<FlatDto> Flats { get; set; }
        public ICollection<CarDto> Cars { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public bool IsActive { get; set; }


    }
}