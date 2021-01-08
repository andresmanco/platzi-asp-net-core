using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace platzi_asp_net_core.Controllers
{
    public class CursoController : Controller
    {
        public IActionResult Index(string id)
        {
            if(!string.IsNullOrWhiteSpace(id)){
                var curso = from cur in _context.Cursos
                                where cur.Id == id
                                select cur;
                return View(curso.FirstOrDefault());
            }
            else{
                return View("MultiCurso", _context.Cursos);
            }
        }
        public IActionResult MultiCurso()
        {
            ViewBag.CosaDinamica = "La monja";
            ViewBag.Fecha = DateTime.Now;
        
            return View("MultiCurso", _context.Cursos);
        }

        private EscuelaContext _context;
        public CursoController(EscuelaContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            ViewBag.Fecha = DateTime.Now;
        
            return View();
        }
        [HttpPost]
        public IActionResult Create(Curso curso)
        {
            if(ModelState.IsValid){
                var escuela = _context.Escuelas.FirstOrDefault();
                curso.EscuelaId = escuela.Id;
                _context.Cursos.Add(curso);
                _context.SaveChanges();
                ViewBag.MensajeExtra = "Curso creado";
                return View("Index", curso);
            }
            else{
                return View(curso);
            }
        }
    }
}