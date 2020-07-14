using AutoMapper;
using Materials.Application.Interfaces.Mapping;
using Materials.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Materials.Application.Materials.Queries.GetMaterial
{
    public class MaterialViewModel : IHaveCustomMapping
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
            configuration.CreateMap<Material, MaterialViewModel>()
                .ForMember(mDTO => mDTO.Name, opt => opt.MapFrom(m => m.Name))
                .ForMember(mDTO => mDTO.Author, opt => opt.MapFrom(m => m.Author))
                .ForMember(mDTO => mDTO.PhaseType, opt => opt.MapFrom(m => m.PhaseType))
                .ForMember(mDTO => mDTO.Note, opt => opt.MapFrom(m => m.Note))
                .ForMember(mDTO => mDTO.Visible, opt => opt.MapFrom(m => m.Visible))
                .ForMember(mDTO => mDTO.MaterialFunction, opt => opt.MapFrom(m => m.MaterialFunction));
        }


    }
}
