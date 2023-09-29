using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class ResultadosEquiposProvLeche
    {
        public DateTime? Fecha { get; set; }
        public string? CodProveedor { get; set; }
        public int? NumPredio { get; set; }
        public int? NumEntrega { get; set; }
        public string CodEmpresa { get; set; } = null!;
        public decimal? Grasa { get; set; }
        public decimal? Proteina { get; set; }
        public decimal? ProteinaTotal { get; set; }
        public decimal? ProteinaVerdadera { get; set; }
        public decimal? Lactosa { get; set; }
        public decimal? Solidos { get; set; }
        public decimal? Sng { get; set; }
        public decimal? Urea { get; set; }
        public decimal? Fpd { get; set; }
        public decimal? Ccs { get; set; }
        public decimal? Cbt { get; set; }
        public decimal? Ufc { get; set; }
    }
}
