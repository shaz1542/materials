using AutoMapper;
using Materials.Application.Interfaces.Mapping;
using Materials.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Materials.Application.Materials.Queries.GetAllMaterials
{
    public class MaterialDto :IHaveCustomMapping
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Author { get; set; }

        public bool Visible { get; set; }

        public string PhaseType { get; set; }

        public string Note { get; set; }

        public MaterialFunction MaterialFunction { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Material, MaterialDto>()
                .ForMember(pDTO => pDTO.Name, opt => opt.MapFrom(p => p.Name))
                .ForMember(pDTO => pDTO.Author, opt => opt.MapFrom(p => p.Author))
                .ForMember(pDTO => pDTO.PhaseType, opt => opt.MapFrom(p => p.PhaseType))
                .ForMember(pDTO => pDTO.Note, opt => opt.MapFrom(p => p.Note))
                .ForMember(pDTO => pDTO.Visible, opt => opt.MapFrom(p => p.Visible))
                .ForMember(pDTO => pDTO.MaterialFunction, opt => opt.MapFrom(p => p.MaterialFunction));

        }   
    }
}
