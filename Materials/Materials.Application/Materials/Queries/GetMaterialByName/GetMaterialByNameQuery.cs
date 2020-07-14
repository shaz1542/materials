using Materials.Application.Materials.Queries.GetAllMaterials;
using Materials.Application.Materials.Queries.GetMaterial;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Materials.Application.Materials.Queries.GetMaterialByName
{
    public class GetMaterialByNameQuery : IRequest<MaterialViewModel>
    {
        public string Name { get; set; }
    }
}
