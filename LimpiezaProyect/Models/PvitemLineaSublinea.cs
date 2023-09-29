using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class PvitemLineaSublinea
    {
        public int Lineacod { get; set; }
        public string Lineadesc { get; set; } = null!;
        public int Sublineacod { get; set; }
        public string Sublineadesc { get; set; } = null!;
        public string Itemcod { get; set; } = null!;
        public string? ItemDesc { get; set; }
    }
}
