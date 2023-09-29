using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Clproyecto
    {
        public Clproyecto()
        {
            Clclientes = new HashSet<Clcliente>();
        }

        public int Proyectocod { get; set; }
        public string Proyectodec { get; set; } = null!;

        public virtual ICollection<Clcliente> Clclientes { get; set; }
    }
}
