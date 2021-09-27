using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
        }

        public void Inicializar()
        {
            Escuela =
                new Escuela("Contreras Academy",
                    2021,
                    TiposEscuela.Primaria,
                    pais: "Mexico",
                    ciudad: "Tlaxcala");

            Escuela.Cursos =
                new List<Curso>()
                {
                    new Curso()
                    { Nombre = "101", Jornada = Tiposjornada.Mañana },
                    new Curso()
                    { Nombre = "201", Jornada = Tiposjornada.Mañana },
                    new Curso()
                    { Nombre = "301", Jornada = Tiposjornada.Mañana },
                    new Curso()
                    { Nombre = "401", Jornada = Tiposjornada.Tarde },
                    new Curso() { Nombre = "501", Jornada = Tiposjornada.Tarde }
                };
        }
    }
}
