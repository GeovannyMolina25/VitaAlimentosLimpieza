using LimpiezaProyect.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LimpiezaProyect.Controllers
{
    public class ResponsableController : Controller
    {
        private readonly LimpiezaContext _context;

        public ResponsableController(LimpiezaContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.LimpFormularios.ToListAsync());
        }
    }
}
