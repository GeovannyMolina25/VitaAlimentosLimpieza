using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class Clcliente
    {
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
        public string? Salesroute { get; set; }
        public DateTime? Censofch { get; set; }
        public string? Censoexiste { get; set; }
        public string? Censoabc { get; set; }

        public virtual Clbarrio BarriocodNavigation { get; set; } = null!;
        public virtual Clbloque BloquecodNavigation { get; set; } = null!;
        public virtual Clcategorium CategoriacodNavigation { get; set; } = null!;
        public virtual Clgiro GirocodNavigation { get; set; } = null!;
        public virtual Clparroquium ParroquiacodNavigation { get; set; } = null!;
        public virtual Clproyecto ProyectocodNavigation { get; set; } = null!;
        public virtual Clrutum RutacodNavigation { get; set; } = null!;
        public virtual Clzonaadmin ZonaadmincodNavigation { get; set; } = null!;
    }
}
