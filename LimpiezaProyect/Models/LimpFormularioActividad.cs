using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class LimpFormularioActividad
    {
        public LimpFormularioActividad()
        {
            LimpRegistroDetalles = new HashSet<LimpRegistroDetalle>();
        }

        public int CodActividad { get; set; }
        public string? Decsripcion { get; set; }
        public string CodEmpresa { get; set; } = null!;
        public string? CreadoPor { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string? ActualixzadoPor { get; set; }
        public DateTime? FechaHoraActualizacion { get; set; }
        public int CodRegistro { get; set; }
        public string CodFormulario { get; set; } = null!;
        public int? LimpConfFormulario { get; set; }

        public virtual LimpFormulario Cod { get; set; } = null!;
        public virtual ICollection<LimpRegistroDetalle> LimpRegistroDetalles { get; set; }
    }
}
