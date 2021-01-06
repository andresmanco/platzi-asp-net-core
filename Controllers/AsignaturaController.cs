using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;
using System;
using System.Collections.Generic;

namespace platzi_asp_net_core.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura();
            asignatura.UniqueId = Guid.NewGuid().ToString();
            asignatura.Nombre = "Programacion";

            return View(asignatura);
        }
        public IActionResult MultiAsignatura()
        {
            var listaAsignaturas = new List<Asignatura>(){
                            new Asignatura{Nombre="Matemáticas", UniqueId = Guid.NewGuid().ToString()} ,
                            new Asignatura{Nombre="Educación Física", UniqueId = Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Castellano", UniqueId = Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Ciencias Naturales", UniqueId = Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Programacion", UniqueId = Guid.NewGuid().ToString()}
                };

            ViewBag.CosaDinamica = "La monja";
            ViewBag.Fecha = DateTime.Now;
        
            return View("MultiAsignatura", listaAsignaturas);
        }
    }
}