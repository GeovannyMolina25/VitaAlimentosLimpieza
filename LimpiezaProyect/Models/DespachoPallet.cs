using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class DespachoPallet
    {
        public long? PqProdEntregaPtRecId { get; set; }
        public string? PalletId { get; set; }
        public long? DespachoRecId { get; set; }
        public int? CantidadDespachada { get; set; }
        public int? CantidadPallet { get; set; }
        public int? CantidadDisponible { get; set; }
        public string? JabaId { get; set; }
        public string? ItemId { get; set; }
        public string? NumLote { get; set; }
        public int? UnidadesPorJaba { get; set; }
        public DateTime? FechaProduccion { get; set; }
        public int? SecuencialPallet { get; set; }
        public string? Empresa { get; set; }
        public string? CreadoPor { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public long RecId { get; set; }

        public virtual Despacho? DespachoRec { get; set; }
    }
}
