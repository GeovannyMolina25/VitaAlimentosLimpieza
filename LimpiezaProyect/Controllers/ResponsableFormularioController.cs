using LimpiezaProyect.Models;
using LimpiezaProyect.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LimpiezaProyect.Controllers
{
    public class ResponsableFormularioController : Controller
    {
        private readonly LimpiezaContext _context;

        public ResponsableFormularioController(LimpiezaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string CodFormulario)
        {
            var LimpFormularios = _context.LimpFormularios.Where(x=>x.CodFormulario == CodFormulario).ToList();

            return View(LimpFormularios);
        }
        
        public IActionResult CreateForm()
        {
            ViewData["Formularios"] = new SelectList(_context.LimpFormularios, "CodFormulario", "CodFormulario");
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken] //Evitar informacion de afuera
        public async Task<IActionResult> CreateForm(FormViewModel model)
        {
            if (ModelState.IsValid)
            {
                var formularios = new LimpFormulario()
                {
                    CodFormulario = model.CodFormulario,
                    Descripcion = model.Descripcion,
                    CodArea = model.CodArea,
                };
                _context.Add(formularios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Formularios"] = new SelectList(_context.LimpFormularios, "CodFormulario", "CodFormulario",model.CodFormulario);
            return View(model);
        }
       
    }
}
