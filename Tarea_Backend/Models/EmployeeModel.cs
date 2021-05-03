using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_Backend.Models
{
    public class EmployeeModel
    {
        public EmployeeModel()
        {

        }

        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public DateTime? Nacimiento { get; set; }
    }
}

