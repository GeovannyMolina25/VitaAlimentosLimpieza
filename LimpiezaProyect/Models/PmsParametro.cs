using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class PmsParametro
    {
        public int IdParam { get; set; }
        public DateTime? FchinicialLc { get; set; }
        public DateTime? FchfinalPlan { get; set; }
        public DateTime? FchinicialPrecios { get; set; }
        public DateTime? EtlFchcarga { get; set; }
    }
}
