using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class PmsServiciosBasico
    {
        public string Empresa { get; set; } = null!;
        public int Anio { get; set; }
        public int Mes { get; set; }
        public string Sitio { get; set; } = null!;
        public string CodTipoServicio { get; set; } = null!;
        public decimal? Consumo { get; set; }
        public decimal? ValorUnitario { get; set; }
    }
}
