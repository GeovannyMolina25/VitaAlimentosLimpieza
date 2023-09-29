using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class MensajesError
    {
        public Guid Idproceso { get; set; }
        public int Severidad { get; set; }
        public string? Procedimiento { get; set; }
        public int? NumeeroLinea { get; set; }
        public string? Mensaje { get; set; }
        public string? OrdenCompra { get; set; }
        public long? RecIdLineaOc { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string Empresa { get; set; } = null!;
    }
}
