using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class AppProducto
    {
        public string ItemId { get; set; } = null!;
        public string? Name { get; set; }
        public string? TaxItemGroupId { get; set; }
    }
}
