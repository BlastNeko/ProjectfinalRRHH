using System;
using System.Collections.Generic;

namespace ProjectfinalRRHH.Models
{
    public partial class MantenimientoEmpleado
    {
        public int Id { get; set; }
        public int CodigoEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Departamento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public double Salario { get; set; }
        public bool Estatus { get; set; }
        public string Cargo { get; set; }
    }
}
