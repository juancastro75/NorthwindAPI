using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_Backend.Models
{
    public class OrderModel
    {
        public OrderModel()
        {

        }

        public int id { get; set; }
        public decimal? Peso { get; set; }
        public string Direccion { get; set; }
        public string EnviadoPor { get; set; }
        public DateTime? FechaDePedido { get; set; }
        public DateTime? FechaRequerida { get; set; }
        public DateTime? FechaDeEnvio { get; set; }
    }
}
