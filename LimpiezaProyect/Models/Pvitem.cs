using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Pvitem
    {
        public Pvitem()
        {
            Pvprecios = new HashSet<Pvprecio>();
            Pvpresupuestos = new HashSet<Pvpresupuesto>();
            Pvpresupuestoverlines = new HashSet<Pvpresupuestoverline>();
        }

        public int Lineacod { get; set; }
        public int Sublineacod { get; set; }
        public string Itemcod { get; set; } = null!;
        public decimal? Factorlt { get; set; }

        public virtual Pvsublinea Pvsublinea { get; set; } = null!;
        public virtual ICollection<Pvprecio> Pvprecios { get; set; }
        public virtual ICollection<Pvpresupuesto> Pvpresupuestos { get; set; }
        public virtual ICollection<Pvpresupuestoverline> Pvpresupuestoverlines { get; set; }
    }
}
