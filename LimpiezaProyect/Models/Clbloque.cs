using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Clbloque
    {
        public Clbloque()
        {
            Clclientes = new HashSet<Clcliente>();
        }

        public int Bloquecod { get; set; }
        public string Bloquedesc { get; set; } = null!;

        public virtual ICollection<Clcliente> Clclientes { get; set; }
    }
}
