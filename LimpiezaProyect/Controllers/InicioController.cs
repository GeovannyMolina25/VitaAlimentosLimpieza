using LimpiezaProyect.Models;
using Microsoft.AspNetCore.Mvc;
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
            // Obtener la fecha y hora actual
            DateTime fechaHoraActual = DateTime.Now;

            // Pasa la fecha y hora actual a la vista como parte del modelo
            ViewBag.FechaHoraActual = fechaHoraActual;

            // Obtener la lista de áreas desde tu contexto (reemplaza esto con tu lógica)
            var areas = await _context.LimpAreas.ToListAsync();

            return View(areas);
        }
    }
}
