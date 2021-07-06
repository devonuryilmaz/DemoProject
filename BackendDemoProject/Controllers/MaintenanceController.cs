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
    public class MaintenanceController : ControllerBase
    {
        private readonly IMaintenanceService _maintenanceService;

        public MaintenanceController(IMaintenanceService maintenanceService)
        {
            _maintenanceService = maintenanceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var maintenances = await _maintenanceService.GetAllAsync();

            return Ok(maintenances);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var maintenance = await _maintenanceService.GetByIdAsync(id);

            return Ok(maintenance);
        }

        [HttpPost]
        public async Task<IActionResult> Save(Maintenance maintenance)
        {
            var entity = await _maintenanceService.AddAsync(maintenance);

            return Created(String.Empty, entity);
        }

        [HttpPut]
        public IActionResult Update(Maintenance maintenance)
        {
            var updateMaintenance = _maintenanceService.Update(maintenance);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var maintenance = _maintenanceService.GetByIdAsync(id).Result;
            _maintenanceService.Remove(maintenance);

            return NoContent();
        }
    }
}
