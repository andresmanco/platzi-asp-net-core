using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace platzi_asp_net_core.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            return View(_context.Alumnos.FirstOrDefault());
        }
        public IActionResult MultiAlumno()
        {
            ViewBag.CosaDinamica = "La monja";
            ViewBag.Fecha = DateTime.Now;
        
            return View("MultiAlumno", _context.Alumnos);
        }

        private EscuelaContext _context;
        public AlumnoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}