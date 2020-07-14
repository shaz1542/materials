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


namespace Materials.Application.Materials.Queries.GetMaterial
{
    public class GetMaterialQueryHandler : IRequestHandler<GetMaterialQuery, MaterialViewModel>
    {
        private readonly IAsyncDocumentSession _session;
        private readonly IMapper _mapper;


        public GetMaterialQueryHandler(IAsyncDocumentSession session, IMapper mapper)
        {
            _session = session;
            _mapper = mapper;
        }

        public async Task<MaterialViewModel> Handle(GetMaterialQuery request, CancellationToken cancellationToken)
        {

            var materials = await _session.LoadAsync<Material>(request.Id);
                  
            return _mapper.Map<MaterialViewModel>(materials);
        }
    }
}
