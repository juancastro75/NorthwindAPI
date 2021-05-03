using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindAPI.DTOs
{
    public class ProductDTO
    {
        public ProductDTO()
        {

        }

        public int id { get; set; }
        public string Nombre { get; set; }
        public string UnidadesPorCantidad { get; set; }
        public decimal? PrecioPorUnidad { get; set; }
        public short? UnidadesEnVenta { get; set; }
    }
}


