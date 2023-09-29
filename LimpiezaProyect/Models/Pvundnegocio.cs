using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Pvundnegocio
    {
        public Pvundnegocio()
        {
            Pvsubundnegocios = new HashSet<Pvsubundnegocio>();
        }

        public int Undnegociocod { get; set; }
        public string Undnegociodesc { get; set; } = null!;
        public int? Undnegocioord { get; set; }

        public virtual ICollection<Pvsubundnegocio> Pvsubundnegocios { get; set; }
    }
}
