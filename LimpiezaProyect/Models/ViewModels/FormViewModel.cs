namespace LimpiezaProyect.Models.ViewModels
{
    public class FormViewModel
    {

        public int NumFormulario { get; set; }
        public string? CodArea { get; set; }
        public string? CodEmpresa { get; set; }
        public string? FechaHoraCreacion { get; set; }
        public string? CreadoPor { get; set; }
        public string? Turno { get; set; }
        public string? RevisadoPor { get; set; }
        public DateTime? FechaHoraRevisado { get; set; }
        public string? VerificadoPor { get; set; }
        public DateTime? FechaHoraVerificacion { get; set; }
        public int CodRegistro { get; set; }
        public string CodFormulario { get; set; } = null!;
        public string? Estado { get; set; }

    }
}
