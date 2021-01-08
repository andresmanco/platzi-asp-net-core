using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace platzi_asp_net_core.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        [Required(ErrorMessage = "Nombrees un campo obligatorio")]
        [StringLength(9, ErrorMessage= "Maximo 9 caracteres")]
        public override string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
        public List<Alumno> Alumnos{ get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        [Display(Prompt = "Direccion correspondencia", Name = "Address")]
        [Required(ErrorMessage = "Direccion es un campo obligatorio")]
        [MinLength(10, ErrorMessage = "Minimo 10 caracteres")]
        public string Direccion { get; set; }
        public string EscuelaId { get; set; }
        public Escuela Escuela { get; set; }
    }
}