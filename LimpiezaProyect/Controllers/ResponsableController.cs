using LimpiezaProyect.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace LimpiezaProyect.Controllers
{
    public class ResponsableController : Controller
    {
        private readonly LimpiezaContext _context;

        public ResponsableController(LimpiezaContext context)
        {
            _context = context;
        }
        /*public async Task<IActionResult> Index()
        {

            var LimpFormularios = _context.LimpFormularios.Select(x => x.CodArea == "PastP2").ToList();

            return View(await _context.LimpFormularios.ToListAsync());
        }
        */
        
        
        public async Task<IActionResult> Index(string codArea)
        {
            // Ahora puedes usar el valor de codArea en tu consulta
            var LimpFormularios = _context.LimpFormularios.Where(x => x.CodArea == codArea).ToList();
            return View(LimpFormularios);
        }


    }
}
