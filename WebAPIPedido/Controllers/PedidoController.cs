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
    [Route("api/pedidos")]
    public class PedidoController: ControllerBase
    {
        private readonly ApplicationDbContext context;

        public PedidoController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task <ActionResult<List<Pedido>>> Get()
        {
            return await context.Pedidos.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult> Post(Pedido pedido)
        {
            context.Add(pedido);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Pedido pedido, int id)
        {
            if(pedido.IdPedido != id)
            {
                return BadRequest("El Id del Pedido no coincide con el id de la URL");
            }
            var existe = await context.Pedidos.AnyAsync(x => x.IdPedido == id);

            if (!existe)
            {
                return NotFound();
            }
            context.Update(pedido);
            await context.SaveChangesAsync();
            return Ok();
        }

    }
}
