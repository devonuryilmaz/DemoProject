using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackendDemoProject.Core.Entities;
using BackendDemoProject.Data;
using Microsoft.AspNetCore.Authorization;
using BackendDemoProject.Core.Services;

namespace BackendDemoProject.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ActionTypesController : ControllerBase
    {
        private readonly IActionTypeService _actionTypeService;

        public ActionTypesController(IActionTypeService actionTypeService)
        {
            _actionTypeService = actionTypeService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var actionTypes = await _actionTypeService.GetAllAsync();

            return Ok(actionTypes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var actionType = await _actionTypeService.GetByIdAsync(id);

            return Ok(actionType);
        }

        [HttpPost]
        public async Task<IActionResult> Save(ActionType actionType)
        {
            var entity = await _actionTypeService.AddAsync(actionType);

            return Created(String.Empty, entity);
        }

        [HttpPut]
        public IActionResult Update(ActionType actionType)
        {
            var updateActionType = _actionTypeService.Update(actionType);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var actionType = _actionTypeService.GetByIdAsync(id).Result;
            _actionTypeService.Remove(actionType);

            return NoContent();
        }

    }
}
