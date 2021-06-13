using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPIPedido.Entidades
{
    public class Pedido
    { 
        public int Id { get; set; }
        public DateTime Fecha_Pedido { get; set; }
        public DateTime Fecha_Espera { get; set; }
        public DateTime Fecha_Entrega { get; set; }
        public string  Estado { get; set; }
        public string Detalle { get; set; }
        public List<DetallePedido> DetallePedidos { get; set; }
    }
}
