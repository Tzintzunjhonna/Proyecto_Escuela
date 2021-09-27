using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;

using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela =
                new Escuela("Contreras Academy",
                    2021,
                    TiposEscuela.Primaria,
                    pais: "Mexico",
                    ciudad: "Tlaxcala");

            // Añadir los cursos a una lista
            // Agregar a espacio de nombres la lista
            escuela.Cursos =
                new List<Curso>()
                {
                    new Curso()
                    { Nombre = "101", Jornada = Tiposjornada.Tarde },
                    new Curso()
                    { Nombre = "201", Jornada = Tiposjornada.Tarde },
                    new Curso() { Nombre = "301", Jornada = Tiposjornada.Tarde }
                };

            // Agregar un nuevo curso a la lista existente de cursos
            escuela
                .Cursos
                .Add(new Curso()
                { Nombre = "102", Jornada = Tiposjornada.Tarde });

            escuela
                .Cursos
                .Add(new Curso()
                { Nombre = "202", Jornada = Tiposjornada.Tarde });

            // Añadir varios cursos a la lista de curso existente
            var otraColeccion =
                new List<Curso>()
                {
                    new Curso()
                    { Nombre = "401", Jornada = Tiposjornada.Mañana },
                    new Curso()
                    { Nombre = "501", Jornada = Tiposjornada.Mañana },
                    new Curso() { Nombre = "501", Jornada = Tiposjornada.Tarde }
                };

            escuela.Cursos.AddRange (otraColeccion); // Añadir cursos a una lista de cursos creada anteriormente
            ImprimirCursosEscuela (escuela);

            // Es un metodo para poder borrar con expresion regular o delegado
            escuela
                .Cursos
                .RemoveAll(delegate (Curso cur)
                {
                    return cur.Nombre == "301";
                });

            // Es un metodo para borrar llamado Lambda
            escuela
                .Cursos
                .RemoveAll((cur) =>
                    cur.Nombre == "501" && cur.Jornada == Tiposjornada.Mañana);

            /*Se hace una lista / arreglo con los cursos para llamar desde atributo Escuela.cs*/
            /*escuela.Cursos = null; <-- Es una prueba para checar si escuela o cursos estan vacios y resolver*/
            ImprimirCursosEscuela (escuela);
        }

        /* Metodo para imrpimir mas eficaz Los cursos de la escuela*/
        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("\n *************");
            WriteLine("\n Cursos de la escuela");
            WriteLine("\n *************");

            /*  Realizamos un condicional if para checar si hay escuela o cursos dentro de la escuela
                escuela? el signo de interrogacion es para ver si escuela esta vacia
                ! es para verificar si curso esta vacio
                = si tiene datos, los imprime
            */
            if (escuela?.Cursos != null)
            {
                /* se hace un ciclo en cursos para extraer los cursos existentes*/
                foreach (var curso in escuela.Cursos)
                {
                    Console
                        .WriteLine($@"Nombre {curso.Nombre}, Id {
                            curso.UniqueId}");
                }
            }
        }
    }
}
