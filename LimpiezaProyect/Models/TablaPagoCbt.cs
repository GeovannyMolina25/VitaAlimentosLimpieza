using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class TablaPagoCbt
    {
        public int NumTablaPago { get; set; }
        public int Desde { get; set; }
        public int Hasta { get; set; }
        public decimal Valor { get; set; }
        public string Empresa { get; set; } = null!;
        public long CosRegistro { get; set; }
        public string CreadoPor { get; set; } = null!;
        public DateTime FechaHoraCreacion { get; set; }
        public string ActualizadoPor { get; set; } = null!;
        public DateTime FechaHoraActualizacion { get; set; }
        public long CodRegistro { get; set; }
    }
}
