using System;
using CoreEscuela.Entidades;

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

            /*Se hace una lista / arreglo con los cursos */
            var arregloCursos = new Curso[3];

            arregloCursos[0] = new Curso() { Nombre = "101" };

            arregloCursos[1] = new Curso() { Nombre = "201" };

            arregloCursos[2] = new Curso() { Nombre = "301" };

            Console.WriteLine (escuela);

            System.Console.WriteLine("\n ******** Ciclo While*********");
            ImprimirCursosWhile (arregloCursos);

            System.Console.WriteLine("\n ******** Ciclo Do While*********");
            ImprimirCursosDoWhile (arregloCursos);

            System.Console.WriteLine("\n ******* Ciclo For**********");
            ImprimirCursosFor (arregloCursos);

            System.Console.WriteLine("\n *******Ciclp For Each**********");
            ImprimirCursosForEach (arregloCursos);
        }

        /* Se hace un metodo para mandar a imprimir los nombres de una lista / arreglo dentro de un bucle While*/
        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                Console
                    .WriteLine($@"Nombre {arregloCursos[contador].Nombre}, Id {
                        arregloCursos[contador].UniqueId}");
                contador += 1;
            }
        }

        /* Se hace un metodo para mandar a imprimir los nombres de una lista / arreglo dentro de un bucle DoWhile*/
        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            do
            {
                Console
                    .WriteLine($@"Nombre {arregloCursos[contador].Nombre}, Id {
                        arregloCursos[contador].UniqueId}");
                contador += 1;
            }
            while (contador < arregloCursos.Length);
        }

        /* Se hace un metodo para mandar a imprimir los nombres de una lista / arreglo dentro de un bucle For*/
        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                Console
                    .WriteLine($@"Nombre {arregloCursos[i].Nombre}, Id {
                        arregloCursos[i].UniqueId}");
            }
        }

        /* Se hace un metodo para mandar a imprimir los nombres de una lista / arreglo dentro de un bucle For Each*/
        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                Console
                    .WriteLine($@"Nombre {curso.Nombre}, Id {curso.UniqueId}");
            }
        }
    }
}
