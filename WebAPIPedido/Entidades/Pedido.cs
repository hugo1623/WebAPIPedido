using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIPedido.Entidades
{
   
    public class Pedido
    { 
        [Key]
        public int IdPedido { get; set; }
        public DateTime Fecha_Pedido { get; set; }
        public DateTime Fecha_Espera { get; set; }
        public DateTime Fecha_Entrega { get; set; }
        public string  Estado { get; set; }
        public string Detalle { get; set; }
    }
}
