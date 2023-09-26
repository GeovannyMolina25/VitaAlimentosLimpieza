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

        public async Task<IActionResult> Index( string Estado, string CodArea, string CodFormulario, int Numformulario,string CodEmpresa)
        {
            

            TempData["Area"] = CodArea.ToString();
            TempData["Formulario"] = CodFormulario.ToString();
            TempData["NumFormulario"] = Numformulario;
            TempData["Empresa"] = CodEmpresa.ToString();
            TempData["Estado"] = Estado;
            var actividadFormulario = _context.LimpRegistroDetalles.Where(m=>m.NumFormulario == Numformulario).ToList();
            ViewBag.Hola = actividadFormulario;
            
            return View(actividadFormulario);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]

        
        public async Task<ActionResult> Atras(List<LimpRegistroDetalle> model, string CodArea, string CodFormulario, int NumFormulario, string CodEmpresa)
        {
            return RedirectToAction("Index", "ResponsableForm", new { CodFormulario = CodFormulario, CodArea = CodArea, CodEmpresa = CodEmpresa  });
        }
        
        [HttpPost]
        public async Task<IActionResult> Envio(List<LimpRegistroDetalle> model,string CodArea, string CodFormulario, int NumFormulario, string CodEmpresa)
        {
            
                foreach (var detalle in model)
                {
                    var actividadExistente = _context.LimpRegistroDetalles.FirstOrDefault(a => a.CodActividad == detalle.CodActividad && a.NumFormulario == NumFormulario);

                    if (actividadExistente != null)
                    {
                        actividadExistente.Realizado = detalle.Realizado;
                    }
                }

                await _context.SaveChangesAsync();

                TempData["Message"] = "Cambios guardados correctamente";

                return RedirectToAction("Index", "ResponsableForm", new {CodFormulario = CodFormulario, CodArea = CodArea, CodEmpresa = CodEmpresa });
            
        }
        [HttpPost]
        public async Task<IActionResult> Salir( string CodArea,  string CodFormulario, int NumFormulario, string CodEmpresa)
        {

            return RedirectToAction("Index", "ResponsableForm", new { CodFormulario = CodFormulario, CodArea = CodArea, CodEmpresa = CodEmpresa });
        }

    }

}


