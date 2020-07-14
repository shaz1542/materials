using Materials.Domain.Entities;
using MediatR;
using Raven.Client.Documents.Session;
using System.Threading;
using System.Threading.Tasks;

namespace Materials.Application.Materials.Commands.UpdateMaterial
{


    public class UpdateMaterialCommandHandler : IRequestHandler<UpdateMaterialCommand, Unit>
    {
        private readonly IAsyncDocumentSession _session;

        public UpdateMaterialCommandHandler(IAsyncDocumentSession session)
        {
            _session = session;
        }

        public async Task<Unit> Handle(UpdateMaterialCommand request, CancellationToken cancellationToken)
        {
            var  material = await _session.LoadAsync<Material>(request.Id);

            material.Author = request.Author;
            material.Name = request.Name;
            material.Note = request.Note;
            material.PhaseType = request.PhaseType;
            material.Visible = request.Visible;
            material.MaterialFunction = request.MaterialFunction;

            await _session.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
