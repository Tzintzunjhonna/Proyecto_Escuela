using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Alumnos
    {
        public string UniqueId { get; private set; }

        public List<Evaluaciones> Evaluaciones { get; private set; }

        public Alumnos()
        {
            UniqueId = Guid.NewGuid().ToString();
            Evaluaciones = new List<Evaluaciones>();
        }

        public string Nombre { get; set; }
    }
}
