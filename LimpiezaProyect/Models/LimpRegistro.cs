using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class LimpRegistro
    {
        public LimpRegistro()
        {
            LimpRegistroDetalles = new HashSet<LimpRegistroDetalle>();
        }

        public int NumFormulario { get; set; }
        public string? CodArea { get; set; }
        public string? CodEmpresa { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string? CreadoPor { get; set; }
        public string? Turno { get; set; }
        public string? RevisadoPor { get; set; }
        public DateTime? FechaHoraRevisado { get; set; }
        public string? VerificadoPor { get; set; }
        public DateTime? FechaHoraVerificacion { get; set; }
        public int CodRegistro { get; set; }
        public string? CodFormulario { get; set; }
        public string? Estado { get; set; }

        public virtual LimpFormulario? Cod { get; set; }
        public virtual ICollection<LimpRegistroDetalle> LimpRegistroDetalles { get; set; }
    }
}
