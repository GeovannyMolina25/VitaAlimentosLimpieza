using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Pvpresupuestover
    {
        public Pvpresupuestover()
        {
            Pvpresupuestoverlines = new HashSet<Pvpresupuestoverline>();
        }

        public int Anio { get; set; }
        public int Numver { get; set; }
        public string? Txt { get; set; }
        public DateTime EtlFchcarga { get; set; }

        public virtual ICollection<Pvpresupuestoverline> Pvpresupuestoverlines { get; set; }
    }
}
