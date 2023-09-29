using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class DespachoJaba
    {
        public long? DespachoRecId { get; set; }
        public string? Almacen { get; set; }
        public string? Localidad { get; set; }
        public string? ItemId { get; set; }
        public string? JabaId { get; set; }
        public int? UnidadesPorJaba { get; set; }
        public int? JabasDespachadas { get; set; }
        public int? UnidadesDespachadas { get; set; }
        public string? Empresa { get; set; }
        public string? CreadoPor { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public long RecId { get; set; }

        public virtual Despacho? DespachoRec { get; set; }
    }
}
