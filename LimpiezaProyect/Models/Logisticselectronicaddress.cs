using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Logisticselectronicaddress
    {
        public string Locator { get; set; } = null!;
        public string Locatorextension { get; set; } = null!;
        public long Location { get; set; }
        public string Countryregioncode { get; set; } = null!;
        public int Type { get; set; }
        public string Description { get; set; } = null!;
        public int Isinstantmessage { get; set; }
        public int Ismobilephone { get; set; }
        public int Isprimary { get; set; }
        public int Isprivate { get; set; }
        public long Privateforparty { get; set; }
        public string Modifiedby { get; set; } = null!;
        public int Recversion { get; set; }
        public long Partition { get; set; }
        public long Recid { get; set; }
    }
}
