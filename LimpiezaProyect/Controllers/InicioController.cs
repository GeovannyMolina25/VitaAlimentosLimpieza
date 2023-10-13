using LimpiezaProyect.Models;
using LimpiezaProyect.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Globalization;
using System.Runtime.CompilerServices;
using System;

namespace LimpiezaProyect.Controllers
{
    public class InicioController : Controller
    {
        private readonly LimpiezaContext _context;

        public InicioController(LimpiezaContext context)
        {
            _context = context;
        }
        
        [Route("/{rol}/{empresa}/{usuario}")]
        public IActionResult Index(List<string> User, string rol, string empresa, string usuario,DateTime? fechaInicio, DateTime? fechaFin)
        {
             
            DateTime fechaHoraActual = DateTime.Now;
            ViewBag.FechaHoraActual = fechaHoraActual;
            List<LimpArea> areas = _context.LimpAreas.ToList();
            

            if (string.IsNullOrEmpty(rol) || string.IsNullOrEmpty(empresa) || string.IsNullOrEmpty(usuario))
            {
                if (User != null && User.Count >= 3)
                {
                    rol = User[2];       
                    empresa = User[3];   
                    usuario = User[0];   
                }
                
                /*rcajas   else
                   {
                       return RedirectToAction("Error"); 
                   }
                */
            }
            TempData["User"] = new List<string> { usuario, usuario, rol, empresa };
            if (fechaInicio != null || fechaFin!=null)
            {
                    fechaFin = fechaFin.Value.AddDays(1);
                
                var formularios = _context.LimpFormularios
                .Where(r => r.FechaHoraCreacion >= fechaInicio && r.FechaHoraCreacion <= fechaFin)
                .ToList();
                var Countformularios = _context.LimpRegistros.Where(x => x.Estado == "Abierto" && (x.FechaHoraCreacion >= fechaInicio && x.FechaHoraCreacion <= fechaFin)).Count();
                var NoRformularios = _context.LimpRegistros.Where(r => r.FechaHoraRevisado == null && r.Estado != "Abierto" && (r.FechaHoraCreacion >= fechaInicio && r.FechaHoraCreacion <= fechaFin)).Count();
                var Rformularios = _context.LimpRegistros.Where(x => x.Estado == "Revisado"&& (x.FechaHoraCreacion >= fechaInicio && x.FechaHoraCreacion <= fechaFin)).Count();
                var Vformularios = _context.LimpRegistros.Where(r => r.FechaHoraVerificacion != null && r.Estado == "Verificado" && (r.FechaHoraCreacion >= fechaInicio && r.FechaHoraCreacion <= fechaFin)).Count();
                var Cformularios = _context.LimpRegistros.Where(r => r.FechaHoraVerificacion == null && r.Estado == "Cerrado" &&  (r.FechaHoraCreacion >= fechaInicio && r.FechaHoraCreacion <= fechaFin)).Count();
                    TempData["Count"] = Countformularios;
                    TempData["NoRevisado"] = NoRformularios;
                    TempData["Revisado"] = Rformularios;
                    TempData["Verificado"] = Vformularios;
                    TempData["Cerrado"] = Cformularios;
                TempData["FechaInicio"]= fechaInicio;
                    TempData["FechaFin"] = fechaFin;
                    
                    TempData["FechaFinV"] = fechaFin.Value.AddDays(-1);

            }
            else
            {
                if(fechaInicio == null || fechaFin == null)
{
                    DateTime fechaActual = DateTime.Now;
                    fechaInicio = fechaActual.AddDays(-31); 
                    fechaFin = fechaActual.AddDays(1);


                    var Countformularios = _context.LimpRegistros.Where(x => x.Estado == "Abierto" && (x.FechaHoraCreacion >= fechaInicio && x.FechaHoraCreacion <= fechaFin)).Count();
                    var NoRformularios = _context.LimpRegistros.Where(r => r.FechaHoraRevisado == null && r.Estado != "Abierto" && (r.FechaHoraCreacion >= fechaInicio && r.FechaHoraCreacion <= fechaFin)).Count();
                    var Rformularios = _context.LimpRegistros.Where(x => x.Estado == "Revisado" && (x.FechaHoraCreacion >= fechaInicio && x.FechaHoraCreacion <= fechaFin)).Count();
                    var Vformularios = _context.LimpRegistros.Where(r => r.FechaHoraVerificacion != null && r.Estado == "Verificado" && (r.FechaHoraCreacion >= fechaInicio && r.FechaHoraCreacion <= fechaFin)).Count();
                    var Cformularios = _context.LimpRegistros.Where(r => r.FechaHoraVerificacion == null && r.Estado == "Cerrado" && (r.FechaHoraCreacion >= fechaInicio && r.FechaHoraCreacion <= fechaFin)).Count();
                    TempData["Count"] = Countformularios;
                    TempData["NoRevisado"] = NoRformularios;
                    TempData["Revisado"] = Rformularios;
                    TempData["Verificado"] = Vformularios;
                    TempData["FechaInicio"] = fechaInicio;
                    TempData["FechaFin"] = fechaFin;
                    fechaFin = fechaActual;
                    TempData["FechaFinV"] = fechaFin;
                }
            }
            

            return View(areas);
        }

        public IActionResult CreateArea() 
        {
            ViewData["Areas"] = new SelectList(_context.LimpAreas, "CodArea","Descripcion");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //Evitar informacion de afuera
        public async Task<IActionResult> CreateArea(AreaViewModel model)
        {
            var random = new Random();

            if (ModelState.IsValid)
            {
                var areas = new LimpArea()
                {
                    CodEmpresa = model.CodEmpresa,
                    CodArea = model.CodArea,
                    Descripcion = model.Descripcion,
                    CreadoPor = "jmolina"
                };
                _context.Add(areas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
;            }

            ViewData["Areas"] = new SelectList(_context.LimpAreas, "CodArea", "Descripcion",model.Descripcion);

            return View(model);
        }

        
    }
}
