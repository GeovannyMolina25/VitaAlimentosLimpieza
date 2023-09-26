using LimpiezaProyect.Models;
using Microsoft.AspNetCore.Mvc;

public class SupervisorController : Controller
{
    private readonly LimpiezaContext _context;

    public SupervisorController(LimpiezaContext context)
    {
        _context = context;
    }

    public IActionResult Index( List<string> User)
    {
        TempData["User"] = User;
        var documentosRevisados = _context.LimpRegistros.ToList();
        return View(documentosRevisados);
    }

    [HttpPost]
    public IActionResult Filter(string? accion, List<string> User)
    {
        var documentosRevisados = _context.LimpRegistros.ToList();

        if (accion == "1")
        {
            documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado == null).ToList();
            TempData["accion"] = accion.ToString();

        }
        else if (accion == "2")
        {

            documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado != null).ToList();
            TempData["accion"] = accion.ToString();

        }
        TempData["User"] = User;

        return View("Index", documentosRevisados);
    }
    
}
