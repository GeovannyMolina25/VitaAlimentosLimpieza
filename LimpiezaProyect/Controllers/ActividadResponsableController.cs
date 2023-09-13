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

        public async Task<IActionResult> Index()
        {


            return View(await _context.LimpFormularioActividads.ToListAsync());
        }
    }
}
