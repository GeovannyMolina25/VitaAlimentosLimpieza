using LimpiezaProyect.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LimpiezaProyect.Controllers
{
    public class ActividadResponsableController : Controller
    {
        private readonly LimpiezaContext _context;
        public ActividadResponsableController(LimpiezaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index( string CodFormulario)
        {
            var actividadFormulario = _context.LimpFormularioActividads.Where(m=>m.CodFormulario == CodFormulario).ToList();

            return View(actividadFormulario);
        }
    }
}
