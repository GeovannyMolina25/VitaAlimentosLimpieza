using LimpiezaProyect.Models;
using Microsoft.AspNetCore.Mvc;

public class SupervisorController : Controller
{
    private readonly LimpiezaContext _context;

    public SupervisorController(LimpiezaContext context)
    {
        _context = context;
    }

    public IActionResult Index(string? accion,List<string> User)
    {
        TempData["User"] = User;
        TempData["accion"] = accion.ToString();
        var documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado == null && x.Estado != "0").ToList();
        return View(documentosRevisados);
    }

    [HttpPost]
    public IActionResult Filter(string? accion, List<string> User)
    {
        var documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado == null && x.Estado != "0").ToList();
        if (accion == "3")
        {
            documentosRevisados = _context.LimpRegistros.Where(x=>x.Estado != "1").ToList();
        }
        else if (accion == "1")
        {
            documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado == null && x.Estado != "0").ToList();

        }
        else if (accion == "2")
        {
            documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado != null  && x.Estado != "0").ToList();
        }
        TempData["User"] = User;
        TempData["accion"] = accion.ToString();
        return View("Index", documentosRevisados);
    }
    [HttpPost]
    public async Task<IActionResult> AbrirFormulario(string CodArea, string CodFormulario, int NumFormulario, string CodEmpresa, string accion, List<string> User)
    {
        var ActualizarRegistro = _context.LimpRegistros.FirstOrDefault(r => r.NumFormulario == NumFormulario && r.CodArea == CodArea && r.CodEmpresa == CodEmpresa);

        if (ActualizarRegistro != null)
        {
            ActualizarRegistro.Estado = "0";
            _context.SaveChanges();
            return RedirectToAction("Index", new { accion = accion, User = User });
        }
        return View("Error");
    }
    
        [HttpPost]
    public async Task<IActionResult> CerrarFormulario(string CodArea, string CodFormulario, int NumFormulario, string CodEmpresa, List<string> User)
    {
        var ActualizarRegistro = _context.LimpRegistros.FirstOrDefault(r => r.NumFormulario == NumFormulario && r.CodArea == CodArea && r.CodEmpresa == CodEmpresa);

        if (ActualizarRegistro != null)
        {
            ActualizarRegistro.Estado = "1";
            _context.SaveChanges();
            return RedirectToAction("Index", new { NumFormulario = NumFormulario, CodFormulario = CodFormulario, CodArea = CodArea, CodEmpresa = CodEmpresa, User = User });
        }
        return View("Error");
    }
}
