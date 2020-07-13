using Materials.Application.Interfaces;
using MediatR;
using Raven.Client.Documents.Session;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Materials.Application.Materials.Commands.DeleteMaterial
{
    class DeleteMaterialCommandHandler : IRequestHandler<DeleteMaterialCommand>
    {
        private readonly IAsyncDocumentSession _session;

        public DeleteMaterialCommandHandler(IAsyncDocumentSession session)
        {
            _session = session;
        }
        
        public async Task<Unit> Handle(DeleteMaterialCommand request, CancellationToken cancellationToken)
        {
            _session.Delete(request.Id);

            await _session.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
