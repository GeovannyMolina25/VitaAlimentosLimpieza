using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class ResultadoAnalisi
    {
        public int CodRegistro { get; set; }
        public DateTime Fecha { get; set; }
        public string? NumOrdenCompra { get; set; }
        public string? CodProveedor { get; set; }
        public int? NumPredio { get; set; }
        public int? NumEntrega { get; set; }
        public string? NombreProveedor { get; set; }
        public string? NombrePredio { get; set; }
        public string? Grupo { get; set; }
        public decimal? Grasa { get; set; }
        public decimal? Proteina { get; set; }
        public decimal? Ccs { get; set; }
        public decimal? Cbt { get; set; }
        public decimal? PctAgua { get; set; }
        public string? DireccionCorreo { get; set; }
        public string? Observacion { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string CodEmpresa { get; set; } = null!;
        public string CreadoPor { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public long PurchLineRecId { get; set; }
        public string Estado { get; set; } = null!;
        public decimal? PrecioGrasaProteina { get; set; }
        public decimal? PrecioCbt { get; set; }
        public decimal? BonificacionSanidadAnimal { get; set; }
        public decimal? PrecioAcuerdoComercial { get; set; }
        public decimal? PrecioUnitarioPorCalidad { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? DescuentoLinea { get; set; }
        public decimal? DescuentoPct { get; set; }
        public decimal? Valor { get; set; }
        public string InventTransId { get; set; } = null!;
        public DateTime? FechaEnvioCorreo { get; set; }
        public string? Sitio { get; set; }
        public string? TipoCalculoPrecio { get; set; }
        public string? Mensaje { get; set; }
        public long? LabResultadosCalificacion { get; set; }
        public string? Antibioticos { get; set; }
        public int? CodRegistroDairySpec { get; set; }
        public int? CodRegistroBactoCount { get; set; }
        public string? CodTanquero { get; set; }
    }
}
