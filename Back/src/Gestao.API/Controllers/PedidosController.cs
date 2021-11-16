using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gestao.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gestao.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Pedido>> Get()
        {
            return new Pedido[] {};
        }

        [HttpGet("{id}")]
        public ActionResult<Pedido> Get(int id)
        {
            return new Pedido();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
