using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tarea_Backend.Models
{
    public partial class ProductosArribaPromedio
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ContactName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
