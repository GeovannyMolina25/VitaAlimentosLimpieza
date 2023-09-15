using System.ComponentModel.DataAnnotations;

namespace LimpiezaProyect.Models.ViewModels
{
    public class AreaViewModel
    {
        
        
       
        public string CodArea { get; set; } = null!;
       
        public int CodRegistro { get; set; }
        [Required]
        public string? Descripcion { get; set; }
        
        public string CodEmpresa { get; set; } = null!;
        
        public string? CreadoPor { get; set; }
        
        public DateTime? FechaHoraCreacion { get; set; }
        
        public string? ActualizadoPor { get; set; }
        
        public DateTime? FechaHoraActualizacion { get; set; }
    }
}
