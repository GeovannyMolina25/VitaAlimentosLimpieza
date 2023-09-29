using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class ParametrosPago
    {
        public decimal GrasaMaxima { get; set; }
        public decimal GrasaMinima { get; set; }
        public decimal ProteinaMaxima { get; set; }
        public decimal ProteinaMinima { get; set; }
        public decimal PrecioMinimoCalidad { get; set; }
        public string Empresa { get; set; } = null!;
        public long CodRegistro { get; set; }
    }
}
