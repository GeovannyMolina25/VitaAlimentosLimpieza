using LimpiezaProyect.Models;
using LimpiezaProyect.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LimpiezaProyect.Controllers
{
    public class ResponsableFormController : Controller
    {
        private readonly LimpiezaContext _context;

        public ResponsableFormController(LimpiezaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string CodFormulario)
        {
            var codResgistros = _context.LimpRegistros.Where(x => x.CodFormulario == CodFormulario).ToList();
            return View(codResgistros);
        }
        public IActionResult CreateForm()
        {
            ViewData["Registros"] = new SelectList(_context.LimpRegistros, "CodEmpresa", "CodEmpresa");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //Evitar informacion de afuera
        public async Task<IActionResult> CreateForm(FormViewModel model)
        {
            if (ModelState.IsValid)
            {
                var registros = new LimpRegistro()
                {
                    
                    CodArea = "ADIP",
                    CodEmpresa = "PQSA",
                    
                    CreadoPor="Gmolina",
                    Turno = "Mañana",
                    
                    
                    
                    CodFormulario = "T-PRO-RE-025",
                    Estado = "1",
                    
                };
                _context.Add(registros);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Registros"] = new SelectList(_context.LimpRegistros, "CodRegistro", "CodRegistro", model.CodRegistro);
            return View(model);
        }

    }
}
