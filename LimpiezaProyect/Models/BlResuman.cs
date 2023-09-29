using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class BlResuman
    {
        public string Itemid { get; set; } = null!;
        public string? Itemdesc { get; set; }
        public string? Producido { get; set; }
        public string? Armado { get; set; }
        public string? Comprado { get; set; }
        public string? Vendido { get; set; }
        public string? RevisadoPrecios { get; set; }
    }
}
