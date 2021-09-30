using System;
using System.Collections.Generic;

namespace CoreGym.Entidades
{
    public class Clientes
    {
        public string UniqueId { get; private set; }

        public List<Costos> Costos { get; private set; }

        public Clientes()
        {
            UniqueId = Guid.NewGuid().ToString();
            Costos = new List<Costos>();
        }

        public string Nombre { get; set; }
    }
}
