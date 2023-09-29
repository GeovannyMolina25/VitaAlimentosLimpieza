using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Pvsubundnegocio
    {
        public Pvsubundnegocio()
        {
            Pvprecios = new HashSet<Pvprecio>();
            Pvpresupuestos = new HashSet<Pvpresupuesto>();
            Pvpresupuestoverlines = new HashSet<Pvpresupuestoverline>();
            Pvundnegocioitems = new HashSet<Pvundnegocioitem>();
        }

        public int Undnegociocod { get; set; }
        public int Subundnegociocod { get; set; }
        public string? Subundnegociodesc { get; set; }
        public int? Subundnegocioord { get; set; }
        public string? Clientecod { get; set; }

        public virtual Pvundnegocio UndnegociocodNavigation { get; set; } = null!;
        public virtual ICollection<Pvprecio> Pvprecios { get; set; }
        public virtual ICollection<Pvpresupuesto> Pvpresupuestos { get; set; }
        public virtual ICollection<Pvpresupuestoverline> Pvpresupuestoverlines { get; set; }
        public virtual ICollection<Pvundnegocioitem> Pvundnegocioitems { get; set; }
    }
}
