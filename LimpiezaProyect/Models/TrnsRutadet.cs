using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class TrnsRutadet
    {
        public int Transporteid { get; set; }
        public string Numguiarem { get; set; } = null!;
        public string Itemid { get; set; } = null!;
        public string Clienteid { get; set; } = null!;
        public string? Bodegaorigen { get; set; }
        public string? Bodegadestino { get; set; }
        public decimal? Unidades { get; set; }
        public decimal? Litros { get; set; }
        public decimal? Valorusd { get; set; }
        public DateTime EtlFchcarga { get; set; }

        public virtual TrnsRutaline TrnsRutaline { get; set; } = null!;
    }
}
