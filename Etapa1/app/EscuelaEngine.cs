using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

using static System.Console;

namespace CoreEscuela
{
    public sealed class EscuelaEngine
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

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            var lista = new List<Evaluación>();
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        var rnd = new Random(System.Environment.TickCount);

                        for (int i = 0; i < 5; i++)
                        {
                            var ev =
                                new Evaluación {
                                    Asignatura = asignatura,
                                    Nombre = $"{asignatura.Nombre} Ev#{i + 1}",
                                    Nota = (float)(5 * rnd.NextDouble()),
                                    Alumno = alumno
                                };
                            alumno.Evaluaciones.Add (ev);
                        }
                    }
                }
            }
        }

        /* Realizando un metodo para cargar asignaturas por cada curso*/
        private void CargarAsignaturas()
        {
            foreach (var Curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas =
                    new List<Asignatura> {
                        new Asignatura { Nombre = "Matematicas" },
                        new Asignatura { Nombre = "Educación Fisica" },
                        new Asignatura { Nombre = "Castellano" },
                        new Asignatura { Nombre = "Ciencias Naturales" }
                    };
                Curso.Asignaturas = listaAsignaturas;
            }
        }

        /* Generamos alumnos al azar de acuerdo a la lista */
        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 =
            {
                "Alba",
                "Felipa",
                "Eusebio",
                "Farid",
                "Donald",
                "Alvaro",
                "Nicolás"
            };
            string[] apellido1 =
            {
                "Ruiz",
                "Sarmiento",
                "Uribe",
                "Maduro",
                "Trump",
                "Toledo",
                "Herrera"
            };
            string[] nombre2 =
            {
                "Freddy",
                "Anabel",
                "Rick",
                "Murty",
                "Silvana",
                "Diomedes",
                "Nicomedes",
                "Teodoro"
            };

            // Recorremos cada miembro de la lista y por cada n1, n2 y a1 de genera un nombre
            var listaAlumnos =
                from n1 in nombre1
                from n2 in nombre2
                from a1 in apellido1
                select new Alumno { Nombre = $"{n1} {n2} {a1}" };

            // se retorna una lista de alimnos de acurdo con su ID y una cantidad especifica
            return listaAlumnos
                .OrderBy((al) => al.UniqueId)
                .Take(cantidad)
                .ToList();
        }

        // Se cargann los cursos
        private void CargarCursos()
        {
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

            // Se realiza un aleatorio por cada curso una cantidad especifica de alumnos
            // de 5 a 20 alumnos por grupo aleatoriamente
            Random rnd = new Random();

            foreach (var c in Escuela.Cursos)
            {
                int cantidadRandom = rnd.Next(5, 20);
                c.Alumnos = GenerarAlumnosAlAzar(cantidadRandom);
            }
        }
    }
}
