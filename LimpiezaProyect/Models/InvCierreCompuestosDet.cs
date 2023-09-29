using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class InvCierreCompuestosDet
    {
        public int IdInvfin { get; set; }
        public string Itemid { get; set; } = null!;
        public string? Itemdesc { get; set; }
        public decimal? Unidades { get; set; }
        public decimal? Litros { get; set; }
        public DateTime? EtlFchcarga { get; set; }

        public virtual InvCierreCompuestosHead IdInvfinNavigation { get; set; } = null!;
    }
}
