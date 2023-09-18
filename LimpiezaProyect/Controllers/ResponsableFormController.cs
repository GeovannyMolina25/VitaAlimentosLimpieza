using LimpiezaProyect.Models;
using LimpiezaProyect.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Threading.Tasks;

namespace LimpiezaProyect.Controllers
{
    public class ResponsableFormController : Controller
    {
        private readonly LimpiezaContext _context;

        public ResponsableFormController(LimpiezaContext context)
        {
            _context = context;
        }

        private async Task<List<LimpRegistro>> ObtenerRegistros(string CodFormulario)
        {
            return await _context.LimpRegistros.Where(x => x.CodFormulario == CodFormulario).ToListAsync();
        }

        public async Task<IActionResult> Index(string CodFormulario)
        {
            // Utiliza el método compartido para obtener los registros basados en CodFormulario
            var codResgistros = await ObtenerRegistros(CodFormulario);

            // Envía los datos a la vista
            return View(codResgistros);
        }

        public IActionResult CreateForm()
        {
            ViewData["Registros"] = new SelectList(_context.LimpRegistros, "CodEmpresa", "CodEmpresa");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateForm(FormViewModel model)
        {
            if (ModelState.IsValid)
            {
                var registros = new LimpRegistro()
                {
                    CodArea = "ADIP",
                    CodEmpresa = "PQSA",
                    CreadoPor = "Gmolina",
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

        [HttpPost]
        public async Task<IActionResult> EliminarRegistro(string CodFormulario)
        {
            if (string.IsNullOrEmpty(CodFormulario))
            {
                return NotFound();
            }

            var registroAEliminar = await _context.LimpRegistros.FirstOrDefaultAsync(x => x.CodFormulario == CodFormulario);

            if (registroAEliminar == null)
            {
                return NotFound();
            }

            // Elimina el registro de la base de datos
            _context.LimpRegistros.Remove(registroAEliminar);
            await _context.SaveChangesAsync();

            // Utiliza el método compartido para obtener los registros actualizados basados en CodFormulario
            var registrosActualizados = await ObtenerRegistros(CodFormulario);

            // Envía los datos actualizados a la vista
            return View("Index", registrosActualizados);
        }
    }
}