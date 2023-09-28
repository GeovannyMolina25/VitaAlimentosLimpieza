﻿using LimpiezaProyect.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LimpiezaProyect.Controllers
{
    public class VerificadorController : Controller
    {
        private readonly LimpiezaContext _context;

        public VerificadorController(LimpiezaContext context)
        {
            _context = context;
        }
        public IActionResult Index(string? accion, List<string> User)
        {

            TempData["User"] = User;
            TempData["accion"] = accion.ToString();
            var documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado == null && x.Estado != "Verificado").ToList();
            if (accion == "1")
            {
                documentosRevisados = _context.LimpRegistros.Where(x => x.Estado == "Abierto").ToList();
            }
            else if (accion == "2")
            {
                documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado == null && x.Estado == "Cerrado").ToList();

            }
            else if (accion == "3")
            {
                documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado != null && x.Estado == "Revisado").ToList();
            }
            else if (accion == "4")
            {
                documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraVerificacion != null && x.Estado == "Verificado").ToList();
            }
            
            return View(documentosRevisados);
        }

        [HttpPost]
        public IActionResult Filter(string? accion, List<string> User)
        {
            var documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado == null && x.Estado != "Abierto").ToList();
            if (accion == "1")
            {
                documentosRevisados = _context.LimpRegistros.Where(x => x.Estado == "Abierto").ToList();
            }
            else if (accion == "2")
            {
                documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado == null && x.Estado == "Cerrado").ToList();

            }
            else if (accion == "3")
            {
                documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraRevisado != null && x.Estado == "Revisado").ToList();
            }
            else if (accion == "4")
            {
                documentosRevisados = _context.LimpRegistros.Where(x => x.FechaHoraVerificacion != null && x.Estado == "Verificado").ToList();
            }
            TempData["User"] = User;
            TempData["accion"] = accion.ToString();
            return View("Index", documentosRevisados);
        }
        public async Task<IActionResult> VerificadoForm(string CodArea, int NumFormulario, string CodEmpresa, string? accion, List<string> User)
        {
            var ActualizarRegistro = _context.LimpRegistros.FirstOrDefault(r => r.NumFormulario == NumFormulario && r.CodArea == CodArea && r.CodEmpresa == CodEmpresa);

            if (ActualizarRegistro != null)
            {
                ActualizarRegistro.Estado = "Verificado";
                ActualizarRegistro.FechaHoraVerificacion = DateTime.Now;
                ActualizarRegistro.VerificadoPor = User.FirstOrDefault();
                _context.SaveChanges();
                return RedirectToAction("Index", new { accion = accion, User = User });

            }
            return View("Error");
        }
    }
}