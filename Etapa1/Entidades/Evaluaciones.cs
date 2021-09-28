using System;

namespace CoreEscuela.Entidades

{
    public class Evaluaciones
    {
        public string UniqueId { get; private set; }
        public Evaluaciones() => UniqueId = Guid.NewGuid().ToString();

        public Alumnos Alumno { get; set; }

        public Asignatura Asignatura { get; set; }

        public float Nota { get; set; }

        public string Nombre { get; set; }

        public override string ToString()
        {
            return $"{Nota}, {Alumno.Nombre}, {Asignatura.Nombre}";
        }
    }
}
