using System;


namespace CoreGym.Entidades
{
    public class Costos { 

        public string UniqueId { get; private set; }

        public Costos() => UniqueId = Guid.NewGuid().ToString();

        public Clientes Cliente { get; set; }

        public Area Area { get; set; }

        public int Precio { get; set; }

        public string Nombre { get; set; }

        public override string ToString()
        {
           
            return $"{Precio}, {Cliente.Nombre}, {Area.Nombre}";

           
        }

    }
}
