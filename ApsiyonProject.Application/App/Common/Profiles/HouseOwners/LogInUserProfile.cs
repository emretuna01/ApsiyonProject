﻿using ApsiyonProject.Application.App.Common.Interfaces.Dtos.HouseOwners;
using ApsiyonProject.Domain.App.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Profiles.HouseOwners
{
    public class LogInUserProfile : Profile
    {
        public LogInUserProfile()
        {
            CreateMap<LoginUserDto, HouseOwner>().ReverseMap();
        }       
    }
}
