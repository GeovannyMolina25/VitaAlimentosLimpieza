using LimpiezaProyect.Models;
using Microsoft.AspNetCore.Mvc;
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

        /*
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<ActionResult> Envio(LimpRegistroDetalle model)
        {


            if(ModelState.IsValid)
            {
                var actividades = new LimpRegistroDetalle()
                {
                    NumFormulario = model.NumFormulario,
                    CodFormulario = model.CodFormulario,
                    CodRegistro = model.CodRegistro,
                    CodActividad = model.CodActividad,
                    CodResponsable = model.CodResponsable,
                    Realizado = model.Realizado,
                    FechaHoraCreacion = model.FechaHoraCreacion,
                    CodEmpresa = model.CodEmpresa,
                    CodArea = model.CodArea,
                    FechaHoraVerificacion = model.FechaHoraVerificacion,
                    VerificadoPor = model.VerificadoPor,
                    RevisadoPor = model.RevisadoPor,

                };
                _context.Add(actividades);
                await _context.SaveChangesAsync(); 
                
            }

            return RedirectToAction("Index");
        }
        */
    }

}
