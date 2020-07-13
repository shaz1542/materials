using System;
using System.Collections.Generic;
using System.Text;

namespace Materials.Application.Materials.Queries.GetAllMaterials
{
    public class MaterialsListViewModel
    {
        public IEnumerable<MaterialDto> Materials { get; set; }
    }
}
