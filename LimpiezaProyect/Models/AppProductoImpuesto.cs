using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class AppProductoImpuesto
    {
        public string? ItemId { get; set; }
        public string? TaxId { get; set; }
        public decimal? Factor { get; set; }
    }
}
