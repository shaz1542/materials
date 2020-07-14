using Materials.Application.Materials.Queries.GetAllMaterials;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Materials.Application.Materials.Queries.GetMaterial
{
    public class GetMaterialQuery : IRequest<MaterialViewModel>
    {
        public string Id { get; set; }
    }
}
