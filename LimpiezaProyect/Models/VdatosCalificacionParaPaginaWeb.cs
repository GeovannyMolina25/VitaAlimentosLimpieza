using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class VdatosCalificacionParaPaginaWeb
    {
        public string Empresa { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Purchid { get; set; } = null!;
        public long Linenumber { get; set; }
        public string Vendgroup { get; set; } = null!;
        public string CodProveedor { get; set; } = null!;
        public string? NombreProveedor { get; set; }
        public int CodPredio { get; set; }
        public string? NombrePredio { get; set; }
        public decimal Litros { get; set; }
        public decimal? Grasa { get; set; }
        public decimal? Proteina { get; set; }
        public decimal? Ccs { get; set; }
        public decimal? Cbt { get; set; }
        public decimal PorcentajeAgua { get; set; }
        public decimal ValorGrasaProteina { get; set; }
        public decimal ValorPorCbt { get; set; }
        public decimal BonoSanidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Valor { get; set; }
        public long Recid { get; set; }
    }
}
