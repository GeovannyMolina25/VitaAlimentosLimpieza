﻿using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class LimpRegistroDetalle
    {
        public int? NumFormulario { get; set; }
        public string? CodFormulario { get; set; }
        public int CodRegistro { get; set; }
        public int? CodActividad { get; set; }
        public string? CodResponsable { get; set; }
        public bool? Realizado { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string CodEmpresa { get; set; } = null!;
        public DateTime? FechaHoraVerificacion { get; set; }
        public string? VerificadoPor { get; set; }
        public string? RevisadoPor { get; set; }

        public virtual LimpFormularioActividad? Cod { get; set; }
        public virtual LimpRegistro? NumFormularioNavigation { get; set; }
    }
}
