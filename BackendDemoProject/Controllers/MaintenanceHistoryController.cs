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
    public class MaintenanceHistoryController : ControllerBase
    {
        private readonly IMaintenanceHistoryService _maintenanceHistoryService;

        public MaintenanceHistoryController(IMaintenanceHistoryService maintenanceHistoryService)
        {
            _maintenanceHistoryService = maintenanceHistoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var maintenanceHistories = await _maintenanceHistoryService.GetAllAsync();

            return Ok(maintenanceHistories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var maintenanceHistory = await _maintenanceHistoryService.GetByIdAsync(id);

            return Ok(maintenanceHistory);
        }

        [HttpPost]
        public async Task<IActionResult> Save(MaintenanceHistory maintenanceHistory)
        {
            var entity = await _maintenanceHistoryService.AddAsync(maintenanceHistory);

            return Created(String.Empty, entity);
        }

        [HttpPut]
        public IActionResult Update(MaintenanceHistory maintenanceHistory)
        {
            var updateActionType = _maintenanceHistoryService.Update(maintenanceHistory);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var maintenanceHistory = _maintenanceHistoryService.GetByIdAsync(id).Result;
            _maintenanceHistoryService.Remove(maintenanceHistory);

            return NoContent();
        }
    }
}
