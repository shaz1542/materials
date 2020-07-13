using System;

namespace Materials.Domain.Entities
{
    public class Material
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Author { get; set; }

        public bool Visible { get; set; }

        public string PhaseType { get; set; }

        public string Note { get; set; }

        public MaterialFunction MaterialFunction { get; set; }
    }
}
