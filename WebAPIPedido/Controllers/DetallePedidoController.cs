using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIPedido.Context;
using WebAPIPedido.Entidades;

namespace WebAPIPedido.Controllers
{
    [ApiController]
    [Route("api/detallepedidos")]
    public class DetallePedidoController: ControllerBase
    {
        private readonly ApplicationDbContext context;

        public DetallePedidoController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<DetallePedido>>> Get()
        {
            return await context.DetallePedidos.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(DetallePedido detallepedido)
        {
            context.Add(detallepedido);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(DetallePedido detallepedido, int id)
        {
            if (detallepedido.Id != id)
            {
                return BadRequest("El Id del Pedido no coincide con el id de la URL");
            }
            var existe = await context.DetallePedidos.AnyAsync(x => x.Id == id);

            if (!existe)
            {
                return NotFound();
            }
            context.Update(detallepedido);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.DetallePedidos.AnyAsync(x => x.Id == id);

            if (!existe)
            {
                return NotFound();
            }

            context.Remove(new DetallePedido() { Id = id });
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
