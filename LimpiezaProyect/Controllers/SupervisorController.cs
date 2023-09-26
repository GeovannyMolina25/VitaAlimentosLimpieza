using LimpiezaProyect.Models;
using Microsoft.AspNetCore.Mvc;

public class SupervisorController : Controller
{
    private readonly LimpiezaContext _context;

    public SupervisorController(LimpiezaContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var documentosRevisados = _context.LimpRegistros.ToList();
        return View(documentosRevisados);
    }

    [HttpPost]
    public IActionResult Filter(string? accion)
    {
        var documentosRevisados = new List<LimpRegistro>();

        if (accion == "1")
        {
            documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraVerificacion == null).ToList();
            TempData["accion"] = accion.ToString();

        }
        else if (accion == "2")
        {

            documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraVerificacion != null).ToList();
            TempData["accion"] = accion.ToString();

        }

        return View("Index", documentosRevisados);
    }
    
}
