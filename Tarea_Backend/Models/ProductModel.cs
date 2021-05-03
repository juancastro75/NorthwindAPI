using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_Backend.Models
{
    public class ProductModel
    {
        public ProductModel()
        {

        }

        public int id { get; set; }
        public string Nombre { get; set; }
        public string UnidadesPorCantidad { get; set; }
        public decimal? PrecioPorUnidad { get; set; }
        public short? UnidadesEnVenta { get; set; }
    }
}
