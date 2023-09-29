using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class DespachoProductoTerminado
    {
        public long? DespachoRecId { get; set; }
        public string Localidad { get; set; } = null!;
        public string ArticuloCodigo { get; set; } = null!;
        public string? Articulo { get; set; }
        public int? CantidadPedida { get; set; }
        public int CantidadDespachada { get; set; }
        public string Almacen { get; set; } = null!;
        public string? Empresa { get; set; }
        public string? CreadoPor { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public long RecId { get; set; }

        public virtual Despacho? DespachoRec { get; set; }
    }
}
