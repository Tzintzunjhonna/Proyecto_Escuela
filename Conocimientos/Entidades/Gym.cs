using System.Collections.Generic;
using System;

namespace CoreGym.Entidades
{
    public class Gym
    {
        public string UniqueId {get; private set; } = Guid.NewGuid().ToString();

        string nombre;

        public string Nombre
        {
            get {return nombre;}
            set
            {
                nombre = value.ToUpper();
            }
        }

        public List<Suscripcion> Suscripciones { get; set; }


        // Constructor

        public Gym(string nombre) => (Nombre) = (nombre);



    }
}
