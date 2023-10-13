using LimpiezaProyect.Models;
using Microsoft.AspNetCore.Mvc;

public class SupervisorController : Controller
{
    private readonly LimpiezaContext _context;

    public SupervisorController(LimpiezaContext context)
    {
        _context = context;
    }

    public IActionResult Index(string? accion, List<string> User, DateTime? fechaInicio, DateTime? fechaFin)
    {
        TempData["User"] = User;
        TempData["accion"] = accion.ToString();
        TempData["FechaInicio"] = fechaInicio;
        TempData["FechaFin"] = fechaFin;
        var documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado == null && x.Estado == "Abierto").ToList();
        if (fechaFin == null && fechaInicio == null)
        {
            documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado == null && x.Estado == "Abierto").ToList();
        }
        else
        {
            documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado == null && x.Estado == "Abierto" && (x.FechaHoraCreacion >= fechaInicio && x.FechaHoraCreacion <= fechaFin)).ToList();
        }

        return View(documentosRevisados);
    }

    [HttpPost]
    public IActionResult Filter(string? accion, List<string> User, DateTime? fechaInicio, DateTime? fechaFin)
    {
        var documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado == null && x.Estado != "Abierto").ToList();
        if (fechaFin == null && fechaInicio == null)
        {
            
            if (accion == "3")
            {
                documentosRevisados = _context.LimpRegistros.Where(x => x.Estado == "Abierto").ToList();
            }
            else if (accion == "1")
            {
                documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado == null && x.Estado == "Cerrado").ToList();

            }
            else if (accion == "2")
            {
                documentosRevisados = _context.LimpRegistros.Where(x => x.Estado == "Revisado").ToList();
            }
        }
        else
        {
            if (accion == "3")
            {
                documentosRevisados = _context.LimpRegistros.Where(x => x.Estado == "Abierto" && (x.FechaHoraCreacion >= fechaInicio && x.FechaHoraCreacion <= fechaFin)).ToList();
            }
            else if (accion == "1")
            {
                documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado == null && x.Estado == "Cerrado" && (x.FechaHoraCreacion >= fechaInicio && x.FechaHoraCreacion <= fechaFin)).ToList();

            }
            else if (accion == "2")
            {
                documentosRevisados = _context.LimpRegistros.Where(x => x.Estado == "Revisado" && (x.FechaHoraCreacion >= fechaInicio && x.FechaHoraCreacion <= fechaFin)).ToList();
            }
        }
        TempData["User"] = User;
        TempData["accion"] = accion.ToString();
        TempData["FechaInicio"] = fechaInicio;
        TempData["FechaFin"] = fechaFin;
        return View("Index", documentosRevisados);
    }

        [HttpPost]
    public async Task<IActionResult> CerrarFormulario(string CodArea, string CodFormulario, int NumFormulario, string CodEmpresa, List<string> User)
    {
        var ActualizarRegistro = _context.LimpRegistros.FirstOrDefault(r => r.NumFormulario == NumFormulario && r.CodArea == CodArea && r.CodEmpresa == CodEmpresa);

        if (ActualizarRegistro != null)
        {
            ActualizarRegistro.Estado = "Cerrado";
            _context.SaveChanges();
            return RedirectToAction("Index", new { NumFormulario = NumFormulario, CodFormulario = CodFormulario, CodArea = CodArea, CodEmpresa = CodEmpresa, User = User });
        }
        return View("Error");
    }
}
