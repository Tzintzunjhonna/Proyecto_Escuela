using System;
using System.Collections.Generic;
using CoreEscuela;
using CoreEscuela.Entidades;
using CoreEscuela.Util;

using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();

            Printer.DibujarTitulo("Bienvenidos a la escuela"); // Estamos Imprimiendo un metodo de printer.cs
            Printer.Beep(10000, cantidad: 10); // Lanzamos un pitido (sonido) desde printer.cs
            ImprimirCursosEscuela(engine.Escuela);
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.DibujarTitulo("Cursos escuela");

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
                            curso.UniqueId}, Jornada {curso.Jornada}");
                }
            }
        }
    }
}
