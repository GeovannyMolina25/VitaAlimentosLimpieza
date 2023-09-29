using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class DespachoFactura
    {
        public DespachoFactura()
        {
            DespachoFacturaDetalles = new HashSet<DespachoFacturaDetalle>();
        }

        public long CustInvoiceJourRecId { get; set; }
        public string CodigoCliente { get; set; } = null!;
        public string? Nombre { get; set; }
        public DateTime FechaFactura { get; set; }
        public long? DespachoRecId { get; set; }
        public string NumFactura { get; set; } = null!;
        public string OrdenVenta { get; set; } = null!;
        public string NumberSequenceGroup { get; set; } = null!;
        public string Empresa { get; set; } = null!;
        public string? CreadoPor { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public long RecId { get; set; }

        public virtual Despacho? DespachoRec { get; set; }
        public virtual ICollection<DespachoFacturaDetalle> DespachoFacturaDetalles { get; set; }
    }
}
