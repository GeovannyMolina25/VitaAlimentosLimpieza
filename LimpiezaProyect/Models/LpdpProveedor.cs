using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class LpdpProveedor
    {
        public decimal IdCliente { get; set; }
        public string Empresa { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Ruc { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public string TipoPnj { get; set; } = null!;
        public DateTime EtlFchcarga { get; set; }
    }
}
