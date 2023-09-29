using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class CaRegistroAccesoHikCentral
    {
        public long Id { get; set; }
        public string? IdEmpleado { get; set; }
        public string? FechaHoraAcceso { get; set; }
        public string? FechaAcceso { get; set; }
        public string? HoraAcceso { get; set; }
        public string? NombreDispositivo { get; set; }
        public string? NumSerieDispositivo { get; set; }
        public string? NombrePersona { get; set; }
        public string NumTarjeta { get; set; } = null!;
        public string? Direccion { get; set; }
        public string? Estado { get; set; }
        public DateTime? FechaHoraProceso { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public DateTime? FechaHoraMarcacion { get; set; }
        public string? Importado { get; set; }
        public string? Empresa { get; set; }
    }
}
