using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class TablaPago
    {
        public int NumTablaPago { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public string Empresa { get; set; } = null!;
        public string CreadoPor { get; set; } = null!;
        public DateTime FechaHoraCreacion { get; set; }
        public string ActualizadoPor { get; set; } = null!;
        public DateTime FechaHoraActualizacion { get; set; }
        public long CodRegistro { get; set; }
    }
}
