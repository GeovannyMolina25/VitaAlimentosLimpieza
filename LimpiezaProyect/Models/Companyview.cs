using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Companyview
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public long Partition { get; set; }
        public long Recid { get; set; }
    }
}
