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

        public async Task<IActionResult> Index()
        {
            var LimpFormularios = _context.LimpFormularios.Where(x=>x.CodFormulario == "T-PRO-RE-023").ToList();
            return View(LimpFormularios);
        }
    }
}
