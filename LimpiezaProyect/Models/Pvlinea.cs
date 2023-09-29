using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Pvlinea
    {
        public Pvlinea()
        {
            Pvsublineas = new HashSet<Pvsublinea>();
        }

        public int Lineacod { get; set; }
        public string Lineadesc { get; set; } = null!;
        public int? Lineaord { get; set; }

        public virtual ICollection<Pvsublinea> Pvsublineas { get; set; }
    }
}
