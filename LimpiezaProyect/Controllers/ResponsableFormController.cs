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

            TempData["Area"] = CodArea != null ? CodArea.ToString() : null;
            TempData["Formulario"] = CodFormulario != null ? CodFormulario.ToString() : null;
            TempData["Empresa"] = CodEmpresa != null ? CodEmpresa.ToString() : null;

            return View(codResgistros);
        }

        public async Task<IActionResult> CreateForm(string CodArea, string CodFormulario, string CodEmpresa)
        {
            TempData["Area"] = CodArea.ToString();
            TempData["Formulario"] = CodFormulario.ToString();
            TempData["Empresa"] = CodEmpresa.ToString();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> CreateForm(LimpRegistro model, string CodArea, string CodFormulario,string CodEmpresa)
        {
            if (ModelState.IsValid)
            {
              
                    if (CodArea != null && CodFormulario != null && CodEmpresa != null)
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
                        Estado = "0",
                    };

                    _context.Add(registros);
                    await _context.SaveChangesAsync();
                    TempData["CodArea"] = CodArea;
                    TempData["CodFormulario"] = CodFormulario;
                    TempData["Empresa"] = CodEmpresa;
                    

                    return RedirectToAction("Index", new { CodFormulario = CodFormulario, CodArea = CodArea, CodEmpresa = CodEmpresa });
                }
            }

                ViewData["Registros"] = new SelectList(_context.LimpRegistros, "CodRegistro", "CodRegistro");
                return View();  
        }

            [HttpPost]
        public async Task<IActionResult> EliminarRegistro(string CodArea, int NumFormulario, string CodEmpresa)
        {
            var registroAEliminar = await _context.LimpRegistros.FirstOrDefaultAsync(x => x.NumFormulario == NumFormulario);

            if (registroAEliminar == null)
            {
                return NotFound();
            }

            _context.LimpRegistros.Remove(registroAEliminar);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", new { CodFormulario = registroAEliminar.CodFormulario, CodArea = CodArea,CodEmpresa = CodEmpresa });
        }
        [HttpPost]
        public async Task<IActionResult> Cerrar(string CodArea,string CodFormulario, int NumFormulario, string CodEmpresa)
        {
            var ActualizarRegistro = _context.LimpRegistros.FirstOrDefault(r => r.NumFormulario == NumFormulario && r.CodArea == CodArea && r.CodEmpresa == CodEmpresa);

            if (ActualizarRegistro != null)
            {
                ActualizarRegistro.Estado = "1";
                _context.SaveChanges();
                return RedirectToAction("Index", new { NumFormulario = NumFormulario ,CodFormulario=CodFormulario, CodArea = CodArea, CodEmpresa = CodEmpresa });
            }
            return View("Error");
        }
    }
}