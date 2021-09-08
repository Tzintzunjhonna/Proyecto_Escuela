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

        public TiposEscuela TiposEscuela { get; set; }

        /*Constructor*/

        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);

        public override string ToString(){
            return $"Nombre: {Nombre}\n Tipo: {TiposEscuela}\n Pais: {Pais}\n Ciudad: {Ciudad}";
        }
    }
}
