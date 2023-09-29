using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class ResultadosEquiposParametrosEnsayo
    {
        public string? CodEnsayo { get; set; }
        public string? Descripcion { get; set; }
        public decimal? Minimo { get; set; }
        public decimal? Maximo { get; set; }
        public string? CodEmpresa { get; set; }
    }
}
