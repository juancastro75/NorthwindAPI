using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tarea_Backend.Models
{
    public partial class VentasOrders
    {
        public int OrderId { get; set; }
        public string ContactName { get; set; }
        public double? Monto { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
