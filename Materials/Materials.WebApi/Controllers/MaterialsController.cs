using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Materials.Application.Materials.Queries.GetAllMaterials;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Materials.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialsController : BaseController
    {
        [HttpGet]
        public async Task<MaterialsListViewModel> GetAll()
        {
            return await Mediator.Send(new GetAllMaterialsQuery());
        }

    }
}
