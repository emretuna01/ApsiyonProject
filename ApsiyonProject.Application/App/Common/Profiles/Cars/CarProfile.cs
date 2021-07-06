using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Cars;
using ApsiyonProject.Domain.App.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Profiles.Cars
{
    public class CarProfile:Profile
    {
        public CarProfile()
        {
            CreateMap<CarDto, Car>().ReverseMap();
        }
    }
}
