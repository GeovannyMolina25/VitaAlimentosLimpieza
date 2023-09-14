using LimpiezaProyect.Models;
using Microsoft.AspNetCore.Mvc;

namespace LimpiezaProyect.Controllers
{
    public class ResponsableFormularioController : Controller
    {
        private readonly LimpiezaContext _context;

        public ResponsableFormularioController(LimpiezaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string CodFormulario)
        {
            var LimpFormularios = _context.LimpFormularios.Where(x=>x.CodFormulario == CodFormulario).ToList();

            return View(LimpFormularios);
        }
    }
}
