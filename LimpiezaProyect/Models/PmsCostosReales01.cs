using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class PmsCostosReales01
    {
        public string Empresa { get; set; } = null!;
        public int Anio { get; set; }
        public int Mes { get; set; }
        public string Sitio { get; set; } = null!;
        public string CodTipoCosto { get; set; } = null!;
        public int Orden { get; set; }
        public decimal? Valor { get; set; }
    }
}
