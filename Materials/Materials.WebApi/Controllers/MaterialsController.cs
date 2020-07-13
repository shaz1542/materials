using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Materials.Application.Materials.Commands.CreateMaterial;
using Materials.Application.Materials.Commands.DeleteMaterial;
using Materials.Application.Materials.Commands.UpdateMaterial;
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

        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] CreateMaterialCommand command)
        {
            var MaterialId = await Mediator.Send(command);

            return Ok(MaterialId);
        }


        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateMaterialCommand command)
        {
            await Mediator.Send(command);

            return NoContent();
        }
        
        [HttpDelete("{*id}")]
        public async Task<ActionResult<int>> Delete(string id)
        {
            var MaterialId = await Mediator.Send(new DeleteMaterialCommand { Id = id });

            return Ok(MaterialId);
        }
    }
}
