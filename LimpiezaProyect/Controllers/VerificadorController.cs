using LimpiezaProyect.Models;
using log4net.Core;
using log4net.Repository.Hierarchy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Rotativa.AspNetCore;
using Microsoft.Extensions.Logging;



namespace LimpiezaProyect.Controllers
{
    public class VerificadorController : Controller
    {
        private readonly LimpiezaContext _context;
        

        
        public VerificadorController(LimpiezaContext context)
        {
            _context = context;
        }
        public IActionResult Index(string? accion, List<string> User, DateTime? fechaInicio, DateTime? fechaFin)
        {

            TempData["User"] = User;
            TempData["accion"] = accion.ToString();
            TempData["FechaInicio"] = fechaInicio;
            TempData["FechaFin"] = fechaFin;
            var documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado == null && x.Estado != "Abierto").ToList();
            if (fechaFin != null && fechaInicio != null)
            {
                if (accion == "1")
                {
                    documentosRevisados = _context.LimpRegistros.Where(x => x.Estado == "Abierto" && (x.FechaHoraCreacion >= fechaInicio && x.FechaHoraCreacion <= fechaFin)).ToList();
                }
                else if (accion == "3")
                {
                    documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado != null && x.Estado == "Revisado" && (x.FechaHoraCreacion >= fechaInicio && x.FechaHoraCreacion <= fechaFin)).ToList();
                }
                else if (accion == "4")
                {
                    documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraVerificacion != null && x.Estado == "Verificado" && (x.FechaHoraCreacion >= fechaInicio && x.FechaHoraCreacion <= fechaFin)).ToList();
                }
            }
            else
            {
                if (accion == "1")
                {
                    documentosRevisados = _context.LimpRegistros.Where(x => x.Estado == "Abierto").ToList();
                }
                else if (accion == "3")
                {
                    documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado != null && x.Estado == "Revisado").ToList();
                }
                else if (accion == "4")
                {
                    documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraVerificacion != null && x.Estado == "Verificado").ToList();
                }
            }

            return View(documentosRevisados);
        }

        [HttpPost]
        public IActionResult Filter(string? accion, List<string> User, DateTime? fechaInicio, DateTime? fechaFin)
        {
            var documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado == null && x.Estado != "Abierto").ToList();
            if(fechaFin != null && fechaInicio != null )
            {
                if (accion == "1")
                {
                    documentosRevisados = _context.LimpRegistros.Where(x => x.Estado == "Abierto" && (x.FechaHoraCreacion >= fechaInicio && x.FechaHoraCreacion <= fechaFin)).ToList();
                }
                else if (accion == "3")
                {
                    documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado != null && x.Estado == "Revisado" && (x.FechaHoraCreacion >= fechaInicio && x.FechaHoraCreacion <= fechaFin)).ToList();
                }
                else if (accion == "4")
                {
                    documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraVerificacion != null && x.Estado == "Verificado" && (x.FechaHoraCreacion >= fechaInicio && x.FechaHoraCreacion <= fechaFin)).ToList();
                }
            }
            else
            {
                if (accion == "1")
                {
                    documentosRevisados = _context.LimpRegistros.Where(x => x.Estado == "Abierto").ToList();
                }
                else if (accion == "3")
                {
                    documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado != null && x.Estado == "Revisado").ToList();
                }
                else if (accion == "4")
                {
                    documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraVerificacion != null && x.Estado == "Verificado").ToList();
                }
            }
            TempData["User"] = User;
            TempData["accion"] = accion.ToString();
            TempData["FechaInicio"] =fechaInicio;
            TempData["FechaFin"] = fechaFin;

            return View("Index", documentosRevisados);
        }
        public IActionResult VerificadoForm(string CodArea, int NumFormulario, string CodEmpresa, string? accion, List<string> User, DateTime? fechaInicio, DateTime? fechaFin)
        {
            var ActualizarRegistro = _context.LimpRegistros.FirstOrDefault(r => r.NumFormulario == NumFormulario && r.CodArea == CodArea && r.CodEmpresa == CodEmpresa);
            List<LimpRegistroDetalle> datos = _context.LimpRegistroDetalles.Where(r => r.NumFormulario == NumFormulario ).ToList();

            if (ActualizarRegistro != null)
            {
                ActualizarRegistro.Estado = "Verificado";
                ActualizarRegistro.FechaHoraVerificacion = DateTime.Now;
                ActualizarRegistro.VerificadoPor = User.FirstOrDefault();
                foreach (var detalle in datos)
                {
                    detalle.VerificadoPor = User.FirstOrDefault();
                }
                _context.SaveChanges();
                return RedirectToAction("Filter", new { accion = accion, User = User, fechaInicio=fechaInicio, fechaFin=fechaFin });

            }
            return View("Error");
        }
        [HttpPost]
        public async Task<IActionResult> AbrirFormulario(string CodArea, string CodFormulario, int NumFormulario, string CodEmpresa, string accion, List<string> User)
        {
            var ActualizarRegistro = _context.LimpRegistros.FirstOrDefault(r => r.NumFormulario == NumFormulario && r.CodArea == CodArea && r.CodEmpresa == CodEmpresa);

            if (ActualizarRegistro != null)
            {
                ActualizarRegistro.Estado = "Abierto";
                ActualizarRegistro.RevisadoPor = null;
                ActualizarRegistro.FechaHoraRevisado = null;
                _context.SaveChanges();
                return RedirectToAction("Index", new { accion = accion, User = User });
            }
            return View("Error");
        }
        public async Task<IActionResult> PDF(string CodArea, string CodFormulario, int NumFormulario, string CodEmpresa, string accion, List<string> User)
        {

            var datos = _context.LimpRegistroDetalles.Where(x=>x.NumFormulario == NumFormulario).ToList();

            TempData["CodArea"] = CodArea;
                TempData["CodFormulario"] = CodFormulario;
                TempData["NumFormulario"] = NumFormulario;
                TempData["CodEmpresa"] = CodEmpresa;
                TempData["accion"] = accion;
                TempData["User"] = User;

            return new ViewAsPdf("PDF", datos)
            {
                FileName = $"Reporte - {CodFormulario}.pdf",
                CustomSwitches = $"--page-size A4 --orientation Portrait"
            };

        }



    }
}
