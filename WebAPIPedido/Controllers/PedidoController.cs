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

    }
}
