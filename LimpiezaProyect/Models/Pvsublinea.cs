using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Pvsublinea
    {
        public Pvsublinea()
        {
            Pvitems = new HashSet<Pvitem>();
        }

        public int Lineacod { get; set; }
        public int Sublineacod { get; set; }
        public string Sublineadesc { get; set; } = null!;
        public int? Sublineaord { get; set; }

        public virtual Pvlinea LineacodNavigation { get; set; } = null!;
        public virtual ICollection<Pvitem> Pvitems { get; set; }
    }
}
