using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Contreras Academy", 2021);
            escuela.Pais = "Mexico";
            escuela.Ciudad = "Tlaxcala";
            escuela.TiposEscuela = TiposEscuela.Primaria;
            Console.WriteLine (escuela);
        }
    }
}
