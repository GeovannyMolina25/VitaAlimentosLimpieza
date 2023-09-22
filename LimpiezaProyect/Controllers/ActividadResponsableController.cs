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

        public async Task<IActionResult> Index( string CodArea, string CodFormulario, int Numformulario,string CodEmpresa)
        {
            TempData["Area"] = CodArea.ToString();
            TempData["Formulario"] = CodFormulario.ToString();
            TempData["NumFormulario"] = Numformulario;
            TempData["Empresa"] = CodEmpresa.ToString();
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
        public async Task<ActionResult> Envio(List<LimpRegistroDetalle> model, string CodArea, string CodFormulario, int NumFormulario, string CodEmpresa)
        {

            foreach (var detalle in model)
            {

                var detalles = new LimpRegistroDetalle()
                {
                    NumFormulario = NumFormulario,
                    CodFormulario = CodFormulario,
                    CodRegistro = 0,
                    CodActividad = detalle.CodActividad,
                    CodResponsable = "Ngmolina",
                    Realizado = detalle.Realizado,
                    FechaHoraCreacion = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    CodEmpresa = CodEmpresa,
                    FechaHoraVerificacion = DateTime.Now,
                    VerificadoPor = "ngmolina",
                    RevisadoPor = "Gmolina",
                };
                _context.Add(detalles);
            }

            await _context.SaveChangesAsync();

            TempData["Message"] = "Formulario enviado correctamente";

            
            return RedirectToAction("Index", "ResponsableForm", new { CodFormulario = CodFormulario, CodArea = CodArea, CodEmpresa = CodEmpresa });
        }
    }

}


