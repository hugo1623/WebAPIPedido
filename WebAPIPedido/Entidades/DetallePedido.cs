using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIPedido.Entidades
{
    public class DetallePedido
    {
        public int Id{ get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
    }
}
