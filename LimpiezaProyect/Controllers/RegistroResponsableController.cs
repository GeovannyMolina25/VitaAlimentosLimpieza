using LimpiezaProyect.Models;
using Microsoft.AspNetCore.Mvc;

namespace LimpiezaProyect.Controllers
{
    public class RegistroController : Controller
    {
        public readonly LimpiezaContext _context;

        public RegistroController(LimpiezaContext _context)
        {
            _context = _context;
        }

        public async Task<IActionResult> Index(string codFormulario)
        {
            var codFormularios = _context.LimpRegistros.Where(x => x.CodFormulario == codFormulario ).ToList();
            return View(codFormularios);
        }


      
        public IActionResult Index()
        {
            return View();
        }
    }
}
