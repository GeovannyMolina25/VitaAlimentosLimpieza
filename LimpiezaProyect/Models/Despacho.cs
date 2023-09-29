using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Despacho
    {
        public Despacho()
        {
            DespachoFacturas = new HashSet<DespachoFactura>();
            DespachoJabas = new HashSet<DespachoJaba>();
            DespachoPallets = new HashSet<DespachoPallet>();
            DespachoProductoTerminados = new HashSet<DespachoProductoTerminado>();
        }

        public string? Almacen { get; set; }
        public DateTime? FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public string? ResponsableJabas { get; set; }
        public string? ResponsableJabasCodigo { get; set; }
        public string? Estado { get; set; }
        public string? Localidad { get; set; }
        public string? Empresa { get; set; }
        public string? CreadoPor { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public long RecId { get; set; }

        public virtual ICollection<DespachoFactura> DespachoFacturas { get; set; }
        public virtual ICollection<DespachoJaba> DespachoJabas { get; set; }
        public virtual ICollection<DespachoPallet> DespachoPallets { get; set; }
        public virtual ICollection<DespachoProductoTerminado> DespachoProductoTerminados { get; set; }
    }
}
