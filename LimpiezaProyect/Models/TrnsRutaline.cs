using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class TrnsRutaline
    {
        public TrnsRutaline()
        {
            TrnsRutadets = new HashSet<TrnsRutadet>();
        }

        public int Transporteid { get; set; }
        public string Numguiarem { get; set; } = null!;
        public string? Numordventa { get; set; }
        public decimal? Litrostotal { get; set; }
        public DateTime EtlFchcarga { get; set; }

        public virtual TrnsRutum Transporte { get; set; } = null!;
        public virtual ICollection<TrnsRutadet> TrnsRutadets { get; set; }
    }
}
