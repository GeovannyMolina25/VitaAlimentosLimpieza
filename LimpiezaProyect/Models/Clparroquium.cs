using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Clparroquium
    {
        public Clparroquium()
        {
            Clclientes = new HashSet<Clcliente>();
        }

        public int Parroquiacod { get; set; }
        public string Parroquiadesc { get; set; } = null!;

        public virtual ICollection<Clcliente> Clclientes { get; set; }
    }
}
