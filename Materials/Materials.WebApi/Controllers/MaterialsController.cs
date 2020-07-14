﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Materials.Application.Materials.Commands.CreateMaterial;
using Materials.Application.Materials.Commands.DeleteMaterial;
using Materials.Application.Materials.Commands.UpdateMaterial;
using Materials.Application.Materials.Queries.GetAllMaterials;
using Materials.Application.Materials.Queries.GetMaterial;
using Materials.Application.Materials.Queries.GetMaterialByName;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Materials.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialsController : BaseController
    {

        [HttpGet]
        public async Task<MaterialViewModel> GetMaterialByName([FromQuery] string name)
        {
            return await Mediator.Send(new GetMaterialByNameQuery() { Name = name });
        }


        [HttpGet("{*id}")]
        public async Task<MaterialViewModel> GetMeterial(string id)
        {
            return await Mediator.Send(new GetMaterialQuery() { Id = id });
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
