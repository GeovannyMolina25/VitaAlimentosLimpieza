using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class LimpFormulario
    {
        public LimpFormulario()
        {
            LimpFormularioActividads = new HashSet<LimpFormularioActividad>();
            LimpRegistros = new HashSet<LimpRegistro>();
        }

        public string CodFormulario { get; set; } = null!;
        public string? Descripcion { get; set; }
        public int CodRegistro { get; set; }
        public string? CreadoPor { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string? ActualizadoPor { get; set; }
        public DateTime? FechaHoraActualizacion { get; set; }
        public string CodEmpresa { get; set; } = null!;
        public string CodArea { get; set; } = null!;

        public virtual LimpArea Cod { get; set; } = null!;
        public virtual ICollection<LimpFormularioActividad> LimpFormularioActividads { get; set; }
        public virtual ICollection<LimpRegistro> LimpRegistros { get; set; }
    }
}
