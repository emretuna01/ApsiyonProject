﻿using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Buildings;
using ApsiyonProject.Domain.App.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Profiles.Buildings
{
    public class AddBuildingProfile:Profile
    {
        public AddBuildingProfile()
        {
            CreateMap<AddBuildingDto, Building>().ReverseMap();
        }
    }
}
