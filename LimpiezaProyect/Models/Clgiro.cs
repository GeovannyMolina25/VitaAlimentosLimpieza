using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Clgiro
    {
        public Clgiro()
        {
            Clclientes = new HashSet<Clcliente>();
        }

        public int Girocod { get; set; }
        public string Girodesc { get; set; } = null!;
        public string? Subsegmentid { get; set; }

        public virtual ICollection<Clcliente> Clclientes { get; set; }
    }
}
