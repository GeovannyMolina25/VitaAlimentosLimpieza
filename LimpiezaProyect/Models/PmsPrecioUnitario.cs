using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class PmsPrecioUnitario
    {
        public int Anio { get; set; }
        public int Mes { get; set; }
        public string Itemid { get; set; } = null!;
        public DateTime Fchreferencia { get; set; }
        public decimal? Precio { get; set; }
        public DateTime EtlFchcarga { get; set; }
    }
}
