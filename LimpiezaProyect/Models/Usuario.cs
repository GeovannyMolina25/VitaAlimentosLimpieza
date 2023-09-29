using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Usuario
    {
        public int CodRegistro { get; set; }
        public string CodUsuario { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime FechaHoraCreacion { get; set; }
        public string CreadoPor { get; set; } = null!;
        public string? EmpresaInicial { get; set; }
    }
}
