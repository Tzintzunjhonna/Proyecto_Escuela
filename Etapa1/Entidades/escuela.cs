/*Espacio de nombres*/
namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;

        public string Nombre
        {
            get
            {
                return "Copia:" + nombre;
            }
            set
            {
                nombre = value.ToUpper();
            }
        }

        public int AñoDeCreacion { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        private int myVar;

        /*Constructor*/

        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);
    }
}
