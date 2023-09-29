using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Certificado
    {
        public long VendParty { get; set; }
        public string TipoCertificado { get; set; } = null!;
        public DateTime FechaExpiracion { get; set; }
        public DateTime FechaInicio { get; set; }
        public string NumeroDocumento { get; set; } = null!;
        public DateTime FechaRecepcion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Comentarios { get; set; } = null!;
        public DateTime FechaHoraActualizacion { get; set; }
        public string ActualizadoPor { get; set; } = null!;
        public DateTime FechaHoraCreacion { get; set; }
        public string CreadoPor { get; set; } = null!;
        public int CodPredio { get; set; }
        public string Empresa { get; set; } = null!;
        public long CodRegistro { get; set; }
    }
}
