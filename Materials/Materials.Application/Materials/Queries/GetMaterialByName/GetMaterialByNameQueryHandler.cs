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
using Materials.Application.Materials.Queries.GetMaterialByName;
using Raven.Client.Documents.Linq;
using System.Linq;

namespace Materials.Application.Materials.Queries.GetMaterial
{
    public class GetMaterialByNameQueryHandler : IRequestHandler<GetMaterialByNameQuery, MaterialViewModel>
    {
        private readonly IAsyncDocumentSession _session;
        private readonly IMapper _mapper;


        public GetMaterialByNameQueryHandler(IAsyncDocumentSession session, IMapper mapper)
        {
            _session = session;

            _mapper = mapper;
        }

        public async Task<MaterialViewModel> Handle(GetMaterialByNameQuery request, CancellationToken cancellationToken)
        {
            var materials =await  _session.Query<Material>().Where(x => x.Name == request.Name).FirstOrDefaultAsync();
               
            return _mapper.Map<MaterialViewModel>(materials);
        }
    }
}
