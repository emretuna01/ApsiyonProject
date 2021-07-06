using ApsiyonProject.Application.App.Common.Interfaces.Dtos.Flats;
using ApsiyonProject.Domain.App.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Profiles.Flats
{
    public class FlatProfile : Profile
    {
        public FlatProfile()
        {
            CreateMap<FlatDto, Flat>().ReverseMap();
        }
    }
}
