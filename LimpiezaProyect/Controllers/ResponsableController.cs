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

        public  IActionResult Index(string codArea, List<string> User)
        {
            TempData["User"] = User;
            var LimpFormularios = _context.LimpFormularios.Where(x => x.CodArea == codArea).ToList();
            return View(LimpFormularios);
            
        }
        

    }
}
