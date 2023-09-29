using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Clbarrio
    {
        public Clbarrio()
        {
            Clclientes = new HashSet<Clcliente>();
        }

        public int Barriocod { get; set; }
        public string Barriodesc { get; set; } = null!;

        public virtual ICollection<Clcliente> Clclientes { get; set; }
    }
}
