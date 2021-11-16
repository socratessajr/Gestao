using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gestao.Application.Services;
using Gestao.Domain.Models;
using Gestao.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gestao.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CostumerController : ControllerBase
    {
        private readonly ICostumerAppService _costumerService;
        public CostumerController(ICostumerAppService costumerService)
        {
            this._costumerService = costumerService;

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> Get()
        {
            try
            {
                var costumers = await _costumerService.GetAllAsync();
                return Ok(costumers);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                $"Erro ao recuperar lista de clientes. Erro: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> Get(int id)
        {
            try
            {
                var costumer = await _costumerService.GetAsync(id);
                if (costumer != null)
                    return Ok(costumer);
                else
                    return NotFound("Cliente não encontrado!");
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                $"Erro ao recuperar cliente. Erro: {ex.Message}");
            }
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<bool>> Post([FromBody] Cliente model)
        {
            try
            {
                var evento = await _costumerService.InsertOrUpdateAsync(model);
                if (evento == null) return BadRequest("Erro ao tentar adicionar envento");

                return Ok(true);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, 
                $"Erro ao tentar adicionar evento. Erro: {ex.Message}");
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cliente model)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
