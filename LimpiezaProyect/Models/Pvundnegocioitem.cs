using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Pvundnegocioitem
    {
        public int Undnegociocod { get; set; }
        public int Subundnegociocod { get; set; }
        public string Itemcod { get; set; } = null!;
        public string? Clientecod { get; set; }

        public virtual Pvsubundnegocio Pvsubundnegocio { get; set; } = null!;
    }
}
