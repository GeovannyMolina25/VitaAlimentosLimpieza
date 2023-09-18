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
            
            var codResgistros = await ObtenerRegistros(CodFormulario);

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
            // Consulta a la base de datos para obtener los datos necesarios
            var datosDeLaBaseDeDatos = await _context.LimpFormularios
                .Where(r => r.CodArea == "ADIP" && r.CodEmpresa == "PQSA")
                .FirstOrDefaultAsync();

            if (datosDeLaBaseDeDatos != null)
            {
                var registros = new LimpRegistro()
                {
                    NumFormulario = 501,
                    CodArea = datosDeLaBaseDeDatos.CodArea, // Usa el valor de CodArea de la consulta
                    CodEmpresa = datosDeLaBaseDeDatos.CodEmpresa, // Usa el valor de CodEmpresa de la consulta
                    CreadoPor = "Gmolina",
                    Turno = model.Turno,
                    FechaHoraRevisado = DateTime.Now,
                    CodFormulario = datosDeLaBaseDeDatos.CodFormulario,
                    Estado = "1",
                };

                _context.Add(registros);

                // Actualiza la base de datos
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", new { CodFormulario = datosDeLaBaseDeDatos.CodFormulario });
            }
            else
            {
                // Manejar el caso en el que no se encontraron datos en la base de datos
                // Puedes lanzar una excepción, mostrar un mensaje de error, etc.
            }

            ViewData["Registros"] = new SelectList(_context.LimpRegistros, "CodRegistro", "CodRegistro");
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
            _context.LimpRegistros.Remove(registroAEliminar);
            await _context.SaveChangesAsync();

            var registrosActualizados = await ObtenerRegistros(CodFormulario);

            return View("Index", registrosActualizados);
        }
    }
}