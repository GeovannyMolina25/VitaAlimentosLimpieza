using LimpiezaProyect.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LimpiezaProyect.Controllers
{
    public class ActividadResponsableController : Controller
    {
        private readonly LimpiezaContext _context;
        public ActividadResponsableController(LimpiezaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index( string CodFormulario)
        {
            var actividadFormulario = _context.LimpFormularioActividads.Where(m=>m.CodFormulario == CodFormulario).ToList();

            return View(actividadFormulario);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<ActionResult> Envio(LimpRegistroDetalle model)
        {
            var datos = await _context.LimpFormularioActividads
                .Where(r => r.CodActividad == r.CodActividad && r.CodEmpresa == "PQSA")
                .FirstOrDefaultAsync();
            var datosF = await _context.LimpRegistros
                .Where(r => r.CodArea == r.CodArea && r.CodEmpresa == "PQSA")
                .FirstOrDefaultAsync();
            

            var detalles = new LimpRegistroDetalle()
                {
                    NumFormulario = datosF.NumFormulario,
                    CodFormulario = datosF.CodFormulario,
                    
                    CodActividad = datos.CodActividad,
                    CodResponsable = model.CodResponsable,
                    Realizado = true,
                    FechaHoraCreacion = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                CodEmpresa = datos.CodEmpresa,
                    CodArea = datosF.CodArea,
                    FechaHoraVerificacion = DateTime.Now,
                    VerificadoPor = "ngmolina",
                    RevisadoPor = "Gmolina",

                };
                _context.Add(detalles);
                await _context.SaveChangesAsync();
            var registrosActualizados = await _context.LimpRegistros
                    .Where(r => r.CodArea == datosF.CodArea) // Cambia la condición según tus necesidades
                    .ToListAsync();
            TempData["Message"] = "Formulario enviado correctamente";

            return View("Index", registrosActualizados);
        }
    }
}


