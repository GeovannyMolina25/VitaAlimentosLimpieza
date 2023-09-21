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
        public async Task<IActionResult> Index(string CodFormulario, string CodArea, string CodEmpresa)
        {
            var codResgistros = await _context.LimpRegistros.Where(x => x.CodFormulario == CodFormulario).ToListAsync();

            TempData["Area"] = CodArea.ToString();
            TempData["Formulario"] = CodFormulario.ToString();
            TempData["Empresa"] = CodEmpresa.ToString();
            return View(codResgistros);
        }

        

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> CreateForm(LimpRegistro model, string CodArea, string CodFormulario,string CodEmpresa)
            {
            var horaActual = DateTime.Now.TimeOfDay;
            string turno = "";

            if (horaActual >= TimeSpan.Zero && horaActual < TimeSpan.FromHours(12))
            {
                turno = "Mañana";
            }
            else if (horaActual >= TimeSpan.FromHours(12) && horaActual < TimeSpan.FromHours(19))
            {
                turno = "Tarde";
            }
            else
            {
                turno = "Noche";
            }
            var registros = new LimpRegistro()
                {
                    CodArea = CodArea,
                    FechaHoraCreacion = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    CodEmpresa = CodEmpresa,
                    CreadoPor = "Gmolina",
                    Turno = turno,
                    FechaHoraRevisado = DateTime.Now,
                    CodFormulario = CodFormulario,
                    Estado = "1",
                };

                _context.Add(registros);
                await _context.SaveChangesAsync();
                TempData["CodArea"] = CodArea;
                TempData["odFormulario"] = CodFormulario;
                var registrosActualizados = await _context.LimpRegistros
                    .Where(r => r.CodFormulario == CodFormulario) 
                    .ToListAsync();

                return View("Index", registrosActualizados);
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