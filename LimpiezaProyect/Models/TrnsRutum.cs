using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class TrnsRutum
    {
        public TrnsRutum()
        {
            TrnsRutalines = new HashSet<TrnsRutaline>();
        }

        public int Transporteid { get; set; }
        public string Diarionum { get; set; } = null!;
        public DateTime Fchdiario { get; set; }
        public DateTime Fchflete { get; set; }
        public string Rutaid { get; set; } = null!;
        public string? Rutadesc { get; set; }
        public decimal Valoruta { get; set; }
        public string Proveedor { get; set; } = null!;
        public string? Areacomercial { get; set; }
        public DateTime EtlFchcarga { get; set; }

        public virtual ICollection<TrnsRutaline> TrnsRutalines { get; set; }
    }
}
