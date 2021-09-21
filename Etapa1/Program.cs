using System;
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

            /*Se hace una lista / arreglo con los cursos para llamar desde atributo Escuela.cs*/
            escuela.Cursos =
                new Curso[] {
                    new Curso() { Nombre = "101" },
                    new Curso() { Nombre = "201" },
                    new Curso() { Nombre = "301" }
                };

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
