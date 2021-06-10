using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIPedido.Entidades;

namespace WebAPIPedido.Controllers
{
    [ApiController]
    [Route("api/pedidos")]
    public class PedidoController: ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Pedido>> Get()
        {
            return new List<Pedido>()  {
                new Pedido() { IdPedido = 1, Estado = "Pagado", Detalle = " Producto de Limpieza" },
                new Pedido() { IdPedido = 2, Estado = "No Pagado", Detalle = " Producto de Cocina" } };
        }


    }
}
