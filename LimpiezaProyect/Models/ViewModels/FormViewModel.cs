namespace LimpiezaProyect.Models.ViewModels
{
    public class FormViewModel
    {

        public string CodFormulario { get; set; } = null!;
        public string? Descripcion { get; set; }
        public int CodRegistro { get; set; }
        public string? CreadoPor { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string? ActualizadoPor { get; set; }
        public DateTime? FechaHoraActualizacion { get; set; }
        public string CodEmpresa { get; set; } = null!;
        public string CodArea { get; set; } = null!;

    }
}
