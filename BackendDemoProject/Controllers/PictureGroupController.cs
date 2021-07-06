using BackendDemoProject.Core.Entities;
using BackendDemoProject.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendDemoProject.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PictureGroupController : ControllerBase
    {
        private readonly IPictureGroupService _pictureGroupService;

        public PictureGroupController(IPictureGroupService pictureGroupService)
        {
            _pictureGroupService = pictureGroupService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var pictureGroups = await _pictureGroupService.GetAllAsync();

            return Ok(pictureGroups);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var pictureGroup = await _pictureGroupService.GetByIdAsync(id);

            return Ok(pictureGroup);
        }

        [HttpPost]
        public async Task<IActionResult> Save(PictureGroup pictureGroup)
        {
            var entity = await _pictureGroupService.AddAsync(pictureGroup);

            return Created(String.Empty, entity);
        }

        [HttpPut]
        public IActionResult Update(PictureGroup pictureGroup)
        {
            var updatePictureGroup = _pictureGroupService.Update(pictureGroup);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pictureGroup = _pictureGroupService.GetByIdAsync(id).Result;
            _pictureGroupService.Remove(pictureGroup);

            return NoContent();
        }
    }
}
