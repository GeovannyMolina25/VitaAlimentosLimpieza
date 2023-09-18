using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class LimpArea
    {
        public LimpArea()
        {
            LimpFormularios = new HashSet<LimpFormulario>();
        }

        public string CodArea { get; set; } = null!;
        public int CodRegistro { get; set; }
        public string? Descripcion { get; set; }
        public string CodEmpresa { get; set; } = null!;
        public string? CreadoPor { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string? ActualizadoPor { get; set; }
        public DateTime? FechaHoraActualizacion { get; set; }

        public virtual ICollection<LimpFormulario> LimpFormularios { get; set; }
    }
}
