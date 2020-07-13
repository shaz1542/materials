using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Materials.Application.Materials.Commands.DeleteMaterial
{
    public class DeleteMaterialCommand : IRequest
    {
        public string Id { get; set; }
    }
}
