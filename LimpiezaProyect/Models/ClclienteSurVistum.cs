using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class ClclienteSurVistum
    {
        public string? Axruta { get; set; }
        public string? Axsalesgroup { get; set; }
        public int Clientecod { get; set; }
        public int Proyectocod { get; set; }
        public int Bloquecod { get; set; }
        public int Rutacod { get; set; }
        public int Barriocod { get; set; }
        public int Parroquiacod { get; set; }
        public int Zonaadmincod { get; set; }
        public int Girocod { get; set; }
        public int Categoriacod { get; set; }
        public string Codigo { get; set; } = null!;
        public int? Secuencia { get; set; }
        public string? Nombre { get; set; }
        public string? Razonsocial { get; set; }
        public string? Direccion { get; set; }
        public string? Cedula { get; set; }
        public string? Telefono { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public string? Accountnum { get; set; }
        public int Rutacodt { get; set; }
        public string Rutadesc { get; set; } = null!;
    }
}
