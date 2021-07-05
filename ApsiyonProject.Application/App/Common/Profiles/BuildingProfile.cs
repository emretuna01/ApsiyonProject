using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Domain.App.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Application.App.Common.Profiles
{
    public class BuildingProfile:Profile
    {
        public BuildingProfile()
        {
            /*
           CreateMap<BuildingDto, Building>().ReverseMap()
           .ForMember(p => p.BuildingStatus, destinationMember => destinationMember.Ignore())
           .ForMember(p => p.BuildingType, destinationMember => destinationMember.Ignore());
           CreateMap<BuildingDto, BuildingUpdateDto>().ReverseMap();                        
           CreateMap<BuildingUpdateDto,Building>().ReverseMap();
           CreateMap<Building, DefaultBuildingDto>().ReverseMap();


           .ForMember(p => p.BuildingStatus, destinationMember => destinationMember.MapFrom(z => z.BuildingStatus))         
           .ForMember(p => p.BuildingTypeId, destinationMember => destinationMember.Ignore())
           .ForMember(p => p.BuildingStatus, destinationMember => destinationMember.MapFrom(z => z.BuildingStatus))            
           .ForMember(p => p.BuildingType, destinationMember => destinationMember.MapFrom(z => z.BuildingType))
           .ForMember(p => p.Floors,destinationMember => destinationMember.MapFrom(z => z.Floors))                
           */
        }
    }
}
