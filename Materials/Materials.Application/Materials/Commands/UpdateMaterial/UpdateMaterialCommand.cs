using Materials.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Materials.Application.Materials.Commands.UpdateMaterial
{
    public class UpdateMaterialCommand : IRequest
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public bool Visible { get; set; }
        public string PhaseType { get; set; }
        public string Note { get; set; }
        public MaterialFunction MaterialFunction { get; set; }
    }

}
