using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela.Entidades
{
    public class Alumno : ObjetoEscuelaBase
    {
        public List<Evaluación> Evaluaciones
        { get; set;
        } = new List<Evaluación>();
    }
}
