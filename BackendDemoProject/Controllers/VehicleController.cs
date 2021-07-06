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
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var actionTypes = await _vehicleService.GetAllAsync();

            return Ok(actionTypes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var actionType = await _vehicleService.GetByIdAsync(id);

            return Ok(actionType);
        }

        [HttpPost]
        public async Task<IActionResult> Save(Vehicle vehicle)
        {
            var entity = await _vehicleService.AddAsync(vehicle);

            return Created(String.Empty, entity);
        }

        [HttpPut]
        public IActionResult Update(Vehicle vehicle)
        {
            var updateVehicle = _vehicleService.Update(vehicle);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var vehicle = _vehicleService.GetByIdAsync(id).Result;
            _vehicleService.Remove(vehicle);

            return NoContent();
        }
    }
}
