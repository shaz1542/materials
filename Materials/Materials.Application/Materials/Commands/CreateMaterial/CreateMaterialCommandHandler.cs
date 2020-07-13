
using Materials.Domain.Entities;
using MediatR;
using Raven.Client.Documents.Session;
using System.Threading;
using System.Threading.Tasks;

namespace Materials.Application.Materials.Commands.CreateMaterial
{
    class CreateMaterialCommandHandler : IRequestHandler<CreateMaterialCommand,int>
    {
        private readonly IAsyncDocumentSession _session;

        public CreateMaterialCommandHandler(IAsyncDocumentSession session)
        {
            _session = session;
        }

        public async Task<int> Handle(CreateMaterialCommand request, CancellationToken cancellationToken)
        {
            var document = new Material
            {
                Name = request.Name,
                Author = request.Author,
                Visible = request.Visible,
                PhaseType = request.PhaseType,
                MaterialFunction = new MaterialFunction()
                {
                    TemperatureMin = 0,
                    TemperatureMax = 0
                },
                Note = request.Note,
            };
            await _session.StoreAsync(document);
            await _session.SaveChangesAsync();
            return 1;
        }

    }
}
