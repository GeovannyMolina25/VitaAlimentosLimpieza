using LimpiezaProyect.Models;
using LimpiezaProyect.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        public async Task<IActionResult> Index(string CodFormulario, string CodArea, string CodEmpresa, List<string> User)
        {
            var codResgistros = await _context.LimpRegistros
            .Where(x => x.CodFormulario == CodFormulario)
            .OrderByDescending(x => x.FechaHoraCreacion) 
            .ToListAsync();
            TempData["Area"] = CodArea != null ? CodArea.ToString() : null;
            TempData["Formulario"] = CodFormulario != null ? CodFormulario.ToString() : null;
            TempData["Empresa"] = CodEmpresa != null ? CodEmpresa.ToString() : null;
            TempData["User"] = User;
            

            return View(codResgistros);
        }

        public async Task<IActionResult> Create( string CodArea, string CodFormulario, string CodEmpresa, List<string> User)
        {
            TempData["Area"]= CodArea.ToString();
            TempData["Formulario"] = CodFormulario.ToString();
            TempData["Empresa"] = CodEmpresa.ToString();
            TempData["User"] = User;

            return View();
        }


            [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> EnviarForm( List<LimpRegistroDetalle> model, string turno, string CodArea, string CodFormulario, string CodEmpresa, List<string> User)
        {

            if (ModelState.IsValid && CodArea != null && CodFormulario != null && CodEmpresa != null)
            {
                

                var registros = new LimpRegistro()
                {
                    CodArea = CodArea,
                    FechaHoraCreacion = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    CodEmpresa = CodEmpresa,
                    CreadoPor = User.FirstOrDefault(),
                    RevisadoPor = "Ngmolina",
                    VerificadoPor = "NULL",
                    Turno = turno,
                    FechaHoraRevisado = null,
                    CodFormulario = CodFormulario,
                    Estado = "0",
                };
                _context.Add(registros);
                await _context.SaveChangesAsync();
                var NumFormulario = registros.NumFormulario;
                List<LimpFormularioActividad> datos = _context.LimpFormularioActividads
                 .Where(r => r.CodFormulario == CodFormulario)
                 .ToList();
                foreach (var detalle in datos)
                {
                    var detalles = new LimpRegistroDetalle()
                    {
                        NumFormulario = NumFormulario,
                        CodFormulario = CodFormulario,
                        CodRegistro = registros.CodRegistro,
                        CodActividad = detalle.CodActividad,
                        CodResponsable = User.FirstOrDefault(),
                        Realizado = false,
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

                return RedirectToAction("Index", "ResponsableForm", new { CodFormulario = CodFormulario, CodArea = CodArea, CodEmpresa = CodEmpresa,  User = User});
            }
            ViewData["Registros"] = new SelectList(_context.LimpRegistros, "CodRegistro", "CodRegistro");
            return View();
        }

        

        [HttpPost]
        public async Task<IActionResult> EliminarRegistro(string CodArea, int NumFormulario, string CodEmpresa, List<string> User)
        { 
            var detallesAEliminar = await _context.LimpRegistroDetalles.Where(x => x.NumFormulario == NumFormulario).ToListAsync();

            foreach (var detalle in detallesAEliminar)
            {
                _context.LimpRegistroDetalles.Remove(detalle);
            }
            await _context.SaveChangesAsync();
            var registroAEliminar = await _context.LimpRegistros.FirstOrDefaultAsync(x => x.NumFormulario == NumFormulario);
            if (registroAEliminar == null)
            {
                return NotFound();
            }
            _context.LimpRegistros.Remove(registroAEliminar);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { CodFormulario = registroAEliminar.CodFormulario, CodArea = CodArea, CodEmpresa = CodEmpresa , User = User});
        }


        [HttpPost]
        public async Task<IActionResult> Cerrar(string CodArea,string CodFormulario, int NumFormulario, string CodEmpresa, List<string> User)
        {
            var ActualizarRegistro = _context.LimpRegistros.FirstOrDefault(r => r.NumFormulario == NumFormulario && r.CodArea == CodArea && r.CodEmpresa == CodEmpresa);

            if (ActualizarRegistro != null)
            {
                ActualizarRegistro.Estado = "1";
                _context.SaveChanges();
                return RedirectToAction("Index", new { NumFormulario = NumFormulario ,CodFormulario=CodFormulario, CodArea = CodArea, CodEmpresa = CodEmpresa, User = User });
            }
            return View("Error");
        }
        [HttpPost]
        public async Task<IActionResult> Salir(string CodArea, string CodFormulario, int NumFormulario, string CodEmpresa, List<string> User)
        {
            var LimpFormularios = _context.LimpFormularios.Where(x => x.CodArea == CodArea).ToList();
            return RedirectToAction("Index","Responsable",new { NumFormulario = NumFormulario, CodFormulario = CodFormulario, CodArea = CodArea, CodEmpresa = CodEmpresa, User = User });
        }
        public async Task<IActionResult> SalirRegistro(string CodArea, string CodFormulario, int NumFormulario, string CodEmpresa)
        {
            var LimpFormularios = _context.LimpFormularios.Where(x => x.CodArea == CodArea).ToList();
            return RedirectToAction("Index", "ResponsableForm", new { NumFormulario = NumFormulario, CodFormulario = CodFormulario, CodArea = CodArea, CodEmpresa = CodEmpresa, User = User });
        }
        

    }
}