using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class InfControlProceso
    {
        public string IdProceso { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Origen { get; set; } = null!;
    }
}
