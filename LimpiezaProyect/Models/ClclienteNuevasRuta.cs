using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class ClclienteNuevasRuta
    {
        public string? Zona { get; set; }
        public string Parroquia { get; set; } = null!;
        public string? RutaOriginal { get; set; }
        public string? Barriodesc { get; set; }
        public string? GiroDeNegocio { get; set; }
        public int? Secuencia { get; set; }
        public string? Nombres { get; set; }
        public string? Nombrelocal { get; set; }
        public string? Direccion { get; set; }
        public string? RucCedula { get; set; }
        public string? Telefono { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public string? CodClienteDynamics { get; set; }
    }
}
