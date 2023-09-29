using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class PmsListaprecio
    {
        public string Codigo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public DateTime EtlFchcarga { get; set; }
    }
}
