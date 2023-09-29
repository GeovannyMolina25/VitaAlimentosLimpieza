using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Clcategorium
    {
        public Clcategorium()
        {
            Clclientes = new HashSet<Clcliente>();
        }

        public int Categoriacod { get; set; }
        public string Categoriadesc { get; set; } = null!;

        public virtual ICollection<Clcliente> Clclientes { get; set; }
    }
}
