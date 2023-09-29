using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Clrutum
    {
        public Clrutum()
        {
            Clclientes = new HashSet<Clcliente>();
        }

        public int Rutacod { get; set; }
        public string Rutadesc { get; set; } = null!;

        public virtual ICollection<Clcliente> Clclientes { get; set; }
    }
}
