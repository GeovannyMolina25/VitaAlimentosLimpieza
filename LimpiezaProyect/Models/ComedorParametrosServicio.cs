using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class ComedorParametrosServicio
    {
        public string? TipoServicio { get; set; }
        public string? Sitio { get; set; }
        public TimeSpan? HoraInicial { get; set; }
        public TimeSpan? HoraFinal { get; set; }
    }
}
