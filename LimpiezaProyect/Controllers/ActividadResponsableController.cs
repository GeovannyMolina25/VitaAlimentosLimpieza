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

        public async Task<IActionResult> Index( string Estado, string CodArea, string CodFormulario, int Numformulario,string CodEmpresa, List<string> User)
        {
            

            TempData["Area"] = CodArea.ToString();
            TempData["Formulario"] = CodFormulario.ToString();
            TempData["NumFormulario"] = Numformulario;
            TempData["Empresa"] = CodEmpresa.ToString();
            TempData["Estado"] = Estado;
            TempData["User"] = User;
            var actividadFormulario = _context.LimpRegistroDetalles.Where(m=>m.NumFormulario == Numformulario).ToList();
            ViewBag.Hola = actividadFormulario;
            
            return View(actividadFormulario);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]

        
        public async Task<ActionResult> Atras(List<LimpRegistroDetalle> model, string CodArea, string CodFormulario, int NumFormulario, string CodEmpresa, List<string> User)
        {
            return RedirectToAction("Index", "ResponsableForm", new { CodFormulario = CodFormulario, CodArea = CodArea, CodEmpresa = CodEmpresa, User = User });
        }
        
        [HttpPost]
        public async Task<IActionResult> Envio(List<LimpRegistroDetalle> model,string CodArea, string CodFormulario, int NumFormulario, string CodEmpresa, List<string> User)
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

                return RedirectToAction("Index", "ResponsableForm", new {CodFormulario = CodFormulario, CodArea = CodArea, CodEmpresa = CodEmpresa, User = User });
            
        }
        [HttpPost]
        public async Task<IActionResult> Salir( string CodArea,  string CodFormulario, int NumFormulario, string CodEmpresa, List<string> User)
        {

            return RedirectToAction("Index", "ResponsableForm", new { CodFormulario = CodFormulario, CodArea = CodArea, CodEmpresa = CodEmpresa, User = User });
        }
        public async Task<IActionResult> SalirSupervisor(string CodArea, string CodFormulario, int NumFormulario, string CodEmpresa, List<string> User)
        {

            return RedirectToAction("Index", "Supervisor", new { CodFormulario = CodFormulario, CodArea = CodArea, CodEmpresa = CodEmpresa, User = User });
        }
        public async Task<IActionResult> EnviarVerificado(string CodArea, string CodFormulario, int NumFormulario, string CodEmpresa, List<string> User)
        {
            var ActualizarRegistro = _context.LimpRegistros.FirstOrDefault(r => r.NumFormulario == NumFormulario && r.CodArea == CodArea && r.CodEmpresa == CodEmpresa);

            if (ActualizarRegistro != null)
            {
                ActualizarRegistro.FechaHoraRevisado = DateTime.Now;
                ActualizarRegistro.RevisadoPor = User.ElementAtOrDefault(1);
                _context.SaveChanges();
                return RedirectToAction("Index", "Supervisor", new { CodFormulario = CodFormulario, CodArea = CodArea, CodEmpresa = CodEmpresa, User = User });
            }
            return RedirectToAction("Index", "Supervisor", new { CodFormulario = CodFormulario, CodArea = CodArea, CodEmpresa = CodEmpresa, User = User });
        }

    }

}


