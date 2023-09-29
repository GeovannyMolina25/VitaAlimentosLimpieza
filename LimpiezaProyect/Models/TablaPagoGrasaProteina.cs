using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class TablaPagoGrasaProteina
    {
        public int NumTablaPago { get; set; }
        public decimal Grasa { get; set; }
        public decimal Proteina { get; set; }
        public decimal Valor { get; set; }
        public string Empresa { get; set; } = null!;
        public long CosRegistro { get; set; }
        public string CreadoPor { get; set; } = null!;
        public DateTime FechaHoraCreacion { get; set; }
        public string ActualizadoPor { get; set; } = null!;
        public DateTime FechaHoraActualizacion { get; set; }
    }
}
