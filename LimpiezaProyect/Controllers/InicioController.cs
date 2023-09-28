using LimpiezaProyect.Models;
using LimpiezaProyect.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Runtime.CompilerServices;

namespace LimpiezaProyect.Controllers
{
    public class InicioController : Controller
    {
        private readonly LimpiezaContext _context;

        public InicioController(LimpiezaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            DateTime fechaHoraActual = DateTime.Now;
          
            ViewBag.FechaHoraActual = fechaHoraActual;
            List<LimpArea> areas = _context.LimpAreas.ToList();

            //List<string> Usuario = new List<string>()
            //{
            //    "Nelson Molina","Gmolina","adm", "PQSA"
            //};


            //List<string> Usuario = new List<string>()
            //    {
            //        "Maykel Molina","Mmolina","super", "PQSA"

            //};


            //List<string> Usuario = new List<string>()
            //    {
            //        "Javier Hervas","JHervas","Responsable", "PQSA"

            //    };
            List<string> Usuario = new List<string>()
            {
                "Amy Brigette","    ABrigette", "Verificador","PQSA"
            };

            //List<string> Usuario = new List<string>()
            //    {
            //        "Benito Camelas","BCamelas","Responsable", "PQSA"

            //    };


            TempData["User"] = Usuario;
            var Countformularios = _context.LimpRegistros.Where(x=> x.Estado == "Abierto").Count();
            var NoRformularios = _context.LimpRegistros.Where(r=>r.FechaHoraRevisado == null && r.Estado != "Abierto").Count();
            var Rformularios = _context.LimpRegistros.Where(r => r.FechaHoraRevisado != null && r.Estado == "Revisado").Count();
            var Vformularios = _context.LimpRegistros.Where(r => r.FechaHoraVerificacion != null && r.Estado == "Verificado").Count();
            var Cformularios = _context.LimpRegistros.Where(r => r.FechaHoraVerificacion == null && r.Estado == "Cerrado").Count();
            
            TempData["Count"] = Countformularios;
            TempData["NoRevisado"] = NoRformularios;
            TempData["Revisado"] = Rformularios;
            TempData["Verificado"] = Vformularios;
            TempData["Cerrado"] = Cformularios;

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
