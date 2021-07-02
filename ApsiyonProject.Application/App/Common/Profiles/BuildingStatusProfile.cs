﻿using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Domain.App.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Profiles
{
    public class BuildingStatusProfile:Profile
    {
        public BuildingStatusProfile()
        {
            CreateMap<BuildingStatus, BuildingStatusDto>();
        }
    }
}
