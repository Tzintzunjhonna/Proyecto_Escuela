using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 20)
        {
            WriteLine("".PadLeft(tam, '=')); // Imprimimos el signo = por el tamaño de 20 caracteres
        }

        public static void DibujarTitulo(string titulo) // Imprimimos el Titulo con el mismo tamaño de =
        {
            var tamaño = titulo.Length + 4;
            DibujarLinea (tamaño);
            WriteLine($" | {titulo} |");
            DibujarLinea (tamaño);
        }

        /* Hacemos un metodo para hacer un zumbido en la computadora*/
        public static void Beep(
            int hz = 2000,
            int tiempo = 500,
            int cantidad = 1
        )
        {
            while (cantidad-- > 0)
            {
                System.Console.Beep (hz, tiempo);
            }
        }
    }
}
