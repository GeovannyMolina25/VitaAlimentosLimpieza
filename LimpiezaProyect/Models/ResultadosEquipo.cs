using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class ResultadosEquipo
    {
        public int CodRegistro { get; set; }
        public string? Index { get; set; }
        public string? BatchId { get; set; }
        public string? Barcode { get; set; }
        public int? Sequence { get; set; }
        public int? RackPosition { get; set; }
        public string? CodProveedor { get; set; }
        public DateTime? FechaDescargaLc { get; set; }
        public DateTime? FechaAnalisis { get; set; }
        public string? HoraAnalisis { get; set; }
        public decimal? Fat { get; set; }
        public decimal? GrasaP { get; set; }
        public decimal? ProteinaP { get; set; }
        public int? CbtP { get; set; }
        public int? CcsP { get; set; }
        public int? UfcP { get; set; }
        public decimal? TotalP { get; set; }
        public decimal? TrueP { get; set; }
        public decimal? Lactose { get; set; }
        public decimal? Solids { get; set; }
        public decimal? Snf { get; set; }
        public decimal? Urea { get; set; }
        public decimal? Fpd { get; set; }
        public decimal? Scc { get; set; }
        public string? BatchType { get; set; }
        public decimal? Ibc { get; set; }
        public decimal? Cfu { get; set; }
        public string? Observacion { get; set; }
        public string? Equipo { get; set; }
        public int? NumPredio { get; set; }
        public int? NumEntrega { get; set; }
        public string? NombreProveedor { get; set; }
        public string? NombrePredio { get; set; }
        public string? Grupo { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string? CreadoPor { get; set; }
        public string? ActualizadoPor { get; set; }
        public string CodEmpresa { get; set; } = null!;
        public string? CodTransporte { get; set; }
        public byte? NumDescargaTransporte { get; set; }
        public string Estado { get; set; } = null!;
        public bool? UsadoParaPago { get; set; }
        public string? RevisadoPor { get; set; }
        public string? AprobadoPor { get; set; }
        public DateTime? FechaHoraRevisado { get; set; }
        public DateTime? FechaHoraAprobado { get; set; }
        public string? DireccionCorreo { get; set; }
        public string? RutaArchivo { get; set; }
        public bool? RealizadoEnLabExterno { get; set; }
        public DateTime? FechaHoraGeneracionPdf { get; set; }
        public decimal? GrasaMax { get; set; }
        public decimal? GrasaMin { get; set; }
        public decimal? ProteinaTotalMax { get; set; }
        public decimal? ProteinaTotalMin { get; set; }
        public decimal? SolidosMax { get; set; }
        public decimal? SolidosMin { get; set; }
        public decimal? Ccsmax { get; set; }
        public decimal? Ccsmin { get; set; }
        public string? VersionInforme { get; set; }
    }
}
