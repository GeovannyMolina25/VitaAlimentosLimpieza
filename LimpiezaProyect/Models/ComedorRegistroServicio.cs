using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class ComedorRegistroServicio
    {
        public long Id { get; set; }
        public string CodigoAlternoPersona { get; set; } = null!;
        public string? Nombre { get; set; }
        public DateTime? FechaHoraRegistro { get; set; }
        public DateTime Fecha { get; set; }
        public string? Hora { get; set; }
        public string? OrigenRegistro { get; set; }
        public string? Empresa { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public long? CaRegistroAccesoHikCentraId { get; set; }
        public string? TipoServicio { get; set; }
        public string? CedulaRuc { get; set; }
        public string? SitioServicio { get; set; }
        public string CreadoPor { get; set; } = null!;
    }
}
