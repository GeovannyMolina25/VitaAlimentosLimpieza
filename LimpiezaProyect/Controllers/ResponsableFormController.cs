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
            var datosR = await _context.LimpAreas
                .Where(r => r.CodArea == r.CodArea)
            .FirstOrDefaultAsync();
            var datos = await _context.LimpFormularios
            .Where(r => r.CodArea == datosR.CodArea )
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

            // Actualiza la base de datos
            await _context.SaveChangesAsync();

            // Consulta los registros actualizados que cumplen con la condición
            var registrosActualizados = await _context.LimpRegistros
                .Where(r => r.CodArea == datosR.CodArea) // Cambia la condición según tus necesidades
                .ToListAsync();

            return View("Index", registrosActualizados);
        }

        ViewData["Registros"] = new SelectList(_context.LimpRegistros, "CodRegistro", "CodRegistro");
        return View(model);
    }
        [HttpPost]
        public async Task<IActionResult> EliminarRegistro(string CodRegistro)
        {
            if (!int.TryParse(CodRegistro, out int codigo))
            {
                return NotFound();
            }

            var registroAEliminar = await _context.LimpRegistros.FirstOrDefaultAsync(x => x.CodRegistro == codigo);

            if (registroAEliminar == null)
            {
                return NotFound();
            }

            _context.LimpRegistros.Remove(registroAEliminar);
            await _context.SaveChangesAsync();

            // Obtén la lista actualizada de registros para el mismo formulario
            var registrosActualizados = await ObtenerRegistros(registroAEliminar.CodFormulario);

            // Renderiza la vista Index con la lista actualizada de registros
            return View("Index", registrosActualizados);
        }


    }
}