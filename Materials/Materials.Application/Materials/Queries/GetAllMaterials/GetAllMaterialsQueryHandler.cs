using AutoMapper;
using Materials.Application.Interfaces;
using Materials.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Raven.Client.Documents;
using Raven.Client.Documents.Session;


namespace Materials.Application.Materials.Queries.GetAllMaterials
{
    public class GetAllMaterialsQueryHandler : IRequestHandler<GetAllMaterialsQuery, MaterialsListViewModel>
    {
        private readonly IAsyncDocumentSession _session;
        private readonly IMapper _mapper;


        public GetAllMaterialsQueryHandler(IAsyncDocumentSession session, IMapper mapper)
        {
            _session = session;
            _mapper = mapper;
        }


        public async Task<MaterialsListViewModel> Handle(GetAllMaterialsQuery request, CancellationToken cancellationToken)
        {
 
            var materials = await _session.Query<Material>()
                                             .ToListAsync();
                

            var model = new MaterialsListViewModel
            {
                Materials = _mapper.Map<IEnumerable<MaterialDto>>(materials),
            };
            return model;
        }
    }
}
