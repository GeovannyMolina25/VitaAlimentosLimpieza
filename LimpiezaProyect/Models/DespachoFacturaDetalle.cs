using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class DespachoFacturaDetalle
    {
        public long? DespachoFacturaRecId { get; set; }
        public long CustinvoiceTransRecId { get; set; }
        public string ArticuloCodigo { get; set; } = null!;
        public string? Articulo { get; set; }
        public int? CantidadPedida { get; set; }
        public int CantidadDespachada { get; set; }
        public string Almacen { get; set; } = null!;
        public string Localidad { get; set; } = null!;
        public string? Lote { get; set; }
        public string? Empresa { get; set; }
        public string? CreadoPor { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public long RecId { get; set; }

        public virtual DespachoFactura? DespachoFacturaRec { get; set; }
    }
}
