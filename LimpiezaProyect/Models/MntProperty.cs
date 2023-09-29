using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class MntProperty
    {
        public int Active { get; set; }
        public string City { get; set; } = null!;
        public string County { get; set; } = null!;
        public string Group { get; set; } = null!;
        public string Invoiceaccount { get; set; } = null!;
        public int Propertyid { get; set; }
        public string Propertyname { get; set; } = null!;
        public string Shortname { get; set; } = null!;
        public string State { get; set; } = null!;
        public DateTime Createddatetime { get; set; }
        public string Createdby { get; set; } = null!;
        public string Dataareaid { get; set; } = null!;
        public int Recversion { get; set; }
        public long Partition { get; set; }
        public long Recid { get; set; }
        public decimal Precioruta { get; set; }
        public int Tipocentroacopio { get; set; }
    }
}
