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
    public class StatusController : ControllerBase
    {
        private readonly IStatusService _statusService;

        public StatusController(IStatusService statusService)
        {
            _statusService = statusService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var status = await _statusService.GetAllAsync();

            return Ok(status);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var status = await _statusService.GetByIdAsync(id);

            return Ok(status);
        }

        [HttpPost]
        public async Task<IActionResult> Save(Status status)
        {
            var entity = await _statusService.AddAsync(status);

            return Created(String.Empty, entity);
        }

        [HttpPut]
        public IActionResult Update(Status status)
        {
            var updateStatus = _statusService.Update(status);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var status = _statusService.GetByIdAsync(id).Result;
            _statusService.Remove(status);

            return NoContent();
        }
    }
}
