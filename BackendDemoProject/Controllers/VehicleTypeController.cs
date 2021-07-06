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
    public class VehicleTypeController : ControllerBase
    {
        private readonly IVehicleTypeService _vehicleTypeService;

        public VehicleTypeController(IVehicleTypeService vehicleTypeService)
        {
            _vehicleTypeService = vehicleTypeService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var actionTypes = await _vehicleTypeService.GetAllAsync();

            return Ok(actionTypes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var actionType = await _vehicleTypeService.GetByIdAsync(id);

            return Ok(actionType);
        }

        [HttpPost]
        public async Task<IActionResult> Save(VehicleType vehicleType)
        {
            var entity = await _vehicleTypeService.AddAsync(vehicleType);

            return Created(String.Empty, entity);
        }

        [HttpPut]
        public IActionResult Update(VehicleType vehicleType)
        {
            var updateVehicleType = _vehicleTypeService.Update(vehicleType);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var vehicleType = _vehicleTypeService.GetByIdAsync(id).Result;
            _vehicleTypeService.Remove(vehicleType);

            return NoContent();
        }
    }
}
