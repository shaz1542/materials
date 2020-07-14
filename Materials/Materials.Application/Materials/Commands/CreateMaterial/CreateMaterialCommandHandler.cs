
using Materials.Domain.Entities;
using MediatR;
using Raven.Client.Documents.Session;
using System.Threading;
using System.Threading.Tasks;

namespace Materials.Application.Materials.Commands.CreateMaterial
{
    class CreateMaterialCommandHandler : IRequestHandler<CreateMaterialCommand,Unit>
    {
        private readonly IAsyncDocumentSession _session;

        public CreateMaterialCommandHandler(IAsyncDocumentSession session)
        {
            _session = session;
        }

        public async Task<Unit> Handle(CreateMaterialCommand request, CancellationToken CancellationToken)
        {
            var document = new Material
            {
                Name = request.Name,
                Author = request.Author,
                Visible = request.Visible,
                PhaseType = request.PhaseType,
                MaterialFunction = request.MaterialFunction,
                Note = request.Note,
            };
            await _session.StoreAsync(document);
            await _session.SaveChangesAsync(CancellationToken);
            return Unit.Value;
        }

    }
}
