using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindAPI.DTOs
{
    public class OrderDTO
    {
        public OrderDTO()
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

