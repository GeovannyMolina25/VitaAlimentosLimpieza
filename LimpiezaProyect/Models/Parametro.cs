using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Parametro
    {
        public int CodRegistro { get; set; }
        public string CodParametro { get; set; } = null!;
        public string? Texto { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Entero { get; set; }
        public string CodEmpresa { get; set; } = null!;
    }
}
