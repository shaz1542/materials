using MediatR;

namespace Materials.Application.Materials.Commands.CreateMaterial
{
    public class CreateMaterialCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Note { get; set; }
        public bool Visible { get; set; }
        public string PhaseType { get; set; }
        public string Author { get; set; }

    }
}
