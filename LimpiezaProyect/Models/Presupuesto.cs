using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Presupuesto
    {
        public int Anio { get; set; }
        public string? Txt { get; set; }
        public string? UndNegocio { get; set; }
        public string? SubundNegocio { get; set; }
        public string? Linea { get; set; }
        public string? Sublinea { get; set; }
        public string Itemcod { get; set; } = null!;
        public string? ItemDesc { get; set; }
        public decimal? Litros { get; set; }
        public decimal? Unidades { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
