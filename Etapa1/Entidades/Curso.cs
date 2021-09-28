using System;
using System.Collections.Generic;
namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public  string UniqueId { get; private set; }
        public string Nombre { get; set; }

        public Tiposjornada Jornada { get; set;}

        public List<Asignatura> Asignaturas { get; set;}
        public List<Alumnos> Alumno { get; set;}

        public Curso() => UniqueId = Guid.NewGuid().ToString();
    }  
}