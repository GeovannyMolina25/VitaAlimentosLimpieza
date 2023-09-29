using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class FechaProceso
    {
        public DateTime Fecha { get; set; }
        public string? EstadoRecepcion { get; set; }
        public string? EstadoCalidad { get; set; }
        public string? EstadoPago { get; set; }
        public string Empresa { get; set; } = null!;
    }
}
