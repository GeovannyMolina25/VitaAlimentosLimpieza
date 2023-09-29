using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class VendCertType
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Dataareaid { get; set; } = null!;
        public int Recversion { get; set; }
        public long Partition { get; set; }
        public long Recid { get; set; }
        public int MntIncentivepay { get; set; }
    }
}
