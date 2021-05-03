using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tarea_Backend.Models
{
    public partial class AmericaCustomers
    {
        public string CustomerId { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
    }
}
