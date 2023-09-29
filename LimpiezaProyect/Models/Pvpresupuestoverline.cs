using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Pvpresupuestoverline
    {
        public int Anio { get; set; }
        public int Numver { get; set; }
        public int Lineacod { get; set; }
        public int Sublineacod { get; set; }
        public int Undnegociocod { get; set; }
        public int Subundnegociocod { get; set; }
        public string Itemcod { get; set; } = null!;
        public decimal? Litros { get; set; }
        public decimal? Unidades { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Precioltprom { get; set; }
        public decimal? Costoprduio { get; set; }
        public decimal? Costoprdtlc { get; set; }
        public DateTime EtlFchcarga { get; set; }

        public virtual Pvitem Pvitem { get; set; } = null!;
        public virtual Pvpresupuestover Pvpresupuestover { get; set; } = null!;
        public virtual Pvsubundnegocio Pvsubundnegocio { get; set; } = null!;
    }
}
