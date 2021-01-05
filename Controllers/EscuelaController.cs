using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;
using System;

namespace platzi_asp_net_core.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoDeCreacion = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";
            escuela.Ciudad = "Bogota";
            escuela.Pais = "Colombia";
            escuela.Dirección = "1325 Aala st";
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            

            return View(escuela);
        }
    }
}