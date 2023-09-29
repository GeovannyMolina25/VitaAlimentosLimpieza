using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Clzonaadmin
    {
        public Clzonaadmin()
        {
            Clclientes = new HashSet<Clcliente>();
        }

        public int Zonaadmincod { get; set; }
        public string Zonaadmindesc { get; set; } = null!;

        public virtual ICollection<Clcliente> Clclientes { get; set; }
    }
}
