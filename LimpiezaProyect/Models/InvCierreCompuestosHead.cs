using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class InvCierreCompuestosHead
    {
        public InvCierreCompuestosHead()
        {
            InvCierreCompuestosDets = new HashSet<InvCierreCompuestosDet>();
        }

        public int IdInvfin { get; set; }
        public DateTime? Fchcierre { get; set; }
        public string? Itemid { get; set; }
        public string? Itemdesc { get; set; }
        public decimal? Unidades { get; set; }
        public decimal? Litros { get; set; }
        public DateTime EtlFchcarga { get; set; }

        public virtual ICollection<InvCierreCompuestosDet> InvCierreCompuestosDets { get; set; }
    }
}
