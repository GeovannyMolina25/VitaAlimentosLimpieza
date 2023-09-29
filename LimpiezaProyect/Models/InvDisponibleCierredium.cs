using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class InvDisponibleCierredium
    {
        public int IdInvcierredia { get; set; }
        public DateTime Fchcierre { get; set; }
        public string? TipoDeInventario { get; set; }
        public string? LineaProduccion { get; set; }
        public string? ItemLinea { get; set; }
        public string? ItemSublinea { get; set; }
        public string Itemid { get; set; } = null!;
        public string? ItemDesc { get; set; }
        public decimal? FactorEstad { get; set; }
        public int? VidautilDias { get; set; }
        public string? Armado { get; set; }
        public string Sitio { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public string? BodegaDesc { get; set; }
        public string? Localidad { get; set; }
        public string NoLote { get; set; } = null!;
        public DateTime FchProduccion { get; set; }
        public string EstadoDispLote { get; set; } = null!;
        public decimal Unidades { get; set; }
        public decimal UnidadesEstad { get; set; }
        public DateTime? FchCaducidad { get; set; }
        public int? DiasRestantes { get; set; }
        public decimal? Porcentaje { get; set; }
        public DateTime? FchAutoservicios { get; set; }
        public string? DespAutoservicios { get; set; }
        public DateTime EtlFchcarga { get; set; }
    }
}
