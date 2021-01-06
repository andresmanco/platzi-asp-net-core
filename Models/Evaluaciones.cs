using System;

namespace platzi_asp_net_core.Models
{
    public class Evaluaciones
    {
        public string Id { get; private set; }
        public string Nombre { get; set; }

        public Alumno Alumno { get; set; }
        public Asignatura Asignatura  { get; set; }

        public float Nota { get; set; }

        public Evaluaciones() => Id = Guid.NewGuid().ToString();
    }
}