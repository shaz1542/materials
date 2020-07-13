using AutoMapper;
using Materials.Application.Interfaces.Mapping;
using Materials.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Materials.Application.Materials.Queries.GetAllMaterials
{
    public class MaterialFunctionDto :IHaveCustomMapping
    {
        public float TemperatureMin { get; set; }
        public float TemperatureMax { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<MaterialFunction , MaterialFunctionDto>()
                .ForMember(pDTO => pDTO.TemperatureMin, opt => opt.MapFrom(p => p.TemperatureMin))
                .ForMember(pDTO => pDTO.TemperatureMax, opt => opt.MapFrom(p => p.TemperatureMax));

        }   
    }
}
