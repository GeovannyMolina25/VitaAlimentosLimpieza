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
        public async Task<IActionResult> Index(string CodFormulario)
        {
            
            var codResgistros = await _context.LimpRegistros.Where(x => x.CodFormulario == CodFormulario).ToListAsync();

            return View(codResgistros);
        }

        public IActionResult CreateForm()
        {
            ViewData["Registros"] = new SelectList(_context.LimpRegistros, "CodRegistro", "CodRegistro");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

    public async Task<IActionResult> CreateForm(LimpRegistro model)
    {
        var datos = await _context.LimpFormularios
            .Where(r => r.CodArea == r.CodArea && r.CodEmpresa == "PQSA")
            .FirstOrDefaultAsync();
            if (datos == null)
            {

            }

            if (datos != null)
        {

            var registros = new LimpRegistro()
            {
                CodArea = datos.CodArea,
                FechaHoraCreacion = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                CodEmpresa = datos.CodEmpresa,
                CreadoPor = "Gmolina",
                Turno = model.Turno,
                FechaHoraRevisado = DateTime.Now,
                CodFormulario = datos.CodFormulario,
                Estado = "1",
            };

            _context.Add(registros);
            await _context.SaveChangesAsync();    
            var registrosActualizados = await _context.LimpRegistros
                .Where(r => r.CodArea == datos.CodArea) 
                .ToListAsync();

            return View("Index", registrosActualizados);
        }

        ViewData["Registros"] = new SelectList(_context.LimpRegistros, "CodRegistro", "CodRegistro");
        return View(model);
    }

        [HttpPost]
        public async Task<IActionResult> EliminarRegistro(int NumFormulario)
        {
            var registroAEliminar = await _context.LimpRegistros.FirstOrDefaultAsync(x => x.NumFormulario == NumFormulario);

            if (registroAEliminar == null)
            {
                return NotFound();
            }

            _context.LimpRegistros.Remove(registroAEliminar);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", new { CodFormulario = registroAEliminar.CodFormulario });
        }



    }
}