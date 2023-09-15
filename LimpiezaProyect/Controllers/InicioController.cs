using LimpiezaProyect.Models;
using LimpiezaProyect.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace LimpiezaProyect.Controllers
{
    public class InicioController : Controller
    {
        private readonly LimpiezaContext _context;

        public InicioController(LimpiezaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            
            DateTime fechaHoraActual = DateTime.Now;
          
            ViewBag.FechaHoraActual = fechaHoraActual;

            var areas = await _context.LimpAreas.ToListAsync();

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
