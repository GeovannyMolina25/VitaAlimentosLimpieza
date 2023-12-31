﻿using LimpiezaProyect.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LimpiezaProyect.Controllers
{
    public class ActividadResponsableController : Controller
    {
        private readonly LimpiezaContext _context;
        public ActividadResponsableController(LimpiezaContext context)
        {
            _context = context;
        }

        public IActionResult Index( string Estado, string CodArea, string CodFormulario, int Numformulario,string CodEmpresa, string FechaHoraRevisado,string accion, List<string> User, DateTime? fechaInicio, DateTime? fechaFin)
        {
            

            TempData["Area"] = CodArea.ToString();
            TempData["Formulario"] = CodFormulario.ToString();
            TempData["NumFormulario"] = Numformulario;
            TempData["Empresa"] = CodEmpresa.ToString();
            TempData["Estado"] = Estado;
            TempData["Revisado"] = FechaHoraRevisado;
            TempData["User"] = User;
            TempData["accion"] = accion;
            TempData["FechaInicio"] = fechaInicio;
            TempData["FechaFin"] = fechaFin;
            var actividadFormulario = _context.LimpRegistroDetalles.Where(m=>m.NumFormulario == Numformulario).ToList();
            ViewBag.Hola = actividadFormulario;
            var nombreActividad = _context.LimpFormularioActividads.Where(m => m.CodFormulario == CodFormulario).ToList();
            TempData["Nombres"] = nombreActividad;
            return View(actividadFormulario);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]

        
        public ActionResult Atras(string CodArea, string CodFormulario, string CodEmpresa, List<string> User)
        {
            return RedirectToAction("Index", "ResponsableForm", new { CodFormulario = CodFormulario, CodArea = CodArea, CodEmpresa = CodEmpresa, User = User });
        }
        
        [HttpPost]
        public async Task<IActionResult> Envio(List<LimpRegistroDetalle> model,string CodArea, string CodFormulario, int NumFormulario, string CodEmpresa, List<string> User)
        {
            
                foreach (var detalle in model)
                {
                    var actividadExistente = _context.LimpRegistroDetalles.FirstOrDefault(a => a.CodActividad == detalle.CodActividad && a.NumFormulario == NumFormulario);

                    if (actividadExistente != null)
                    {
                        actividadExistente.Realizado = detalle.Realizado;
                    }
                }

                await _context.SaveChangesAsync();

                TempData["Message"] = "Cambios guardados correctamente";

                return RedirectToAction("Index", "ResponsableForm", new {CodFormulario = CodFormulario, CodArea = CodArea, CodEmpresa = CodEmpresa, User = User });
            
        }
        [HttpPost]
        public IActionResult Salir( string CodArea,  string CodFormulario, string CodEmpresa, List<string> User)
        {

            return RedirectToAction("Index", "ResponsableForm", new { CodFormulario = CodFormulario, CodArea = CodArea, CodEmpresa = CodEmpresa, User = User });
        }
        public IActionResult SalirSupervisor(string accion, List<string> User)
        {

            return RedirectToAction("Index", "Supervisor", new {  accion = accion, User = User });
        }
        public IActionResult EnviarVerificado(string CodArea, int NumFormulario, string CodEmpresa,string accion, List<string> User)
        {
            var ActualizarRegistro = _context.LimpRegistros.FirstOrDefault(r => r.NumFormulario == NumFormulario && r.CodArea == CodArea && r.CodEmpresa == CodEmpresa);
            List<LimpRegistroDetalle> datos = _context.LimpRegistroDetalles.Where(r => r.NumFormulario == NumFormulario && r.CodEmpresa == CodEmpresa).ToList();
            if (ActualizarRegistro != null)
            {
                ActualizarRegistro.FechaHoraRevisado = DateTime.Now;
                ActualizarRegistro.RevisadoPor = User.ElementAtOrDefault(1);
                ActualizarRegistro.Estado = "Revisado";
                foreach(var detalle in datos)
                {
                    detalle.RevisadoPor = User.ElementAtOrDefault(1);
                }
                _context.SaveChanges();
                return RedirectToAction("Index", "Supervisor", new { accion = accion,  User = User});
            }
            return RedirectToAction("Index", "Supervisor", new { accion = accion, User = User });
        }
        public IActionResult SalirVerificador(string accion, List<string> User)
        {

            return RedirectToAction("Index", "Verificador", new { accion = accion, User = User });
        }

    }

}


