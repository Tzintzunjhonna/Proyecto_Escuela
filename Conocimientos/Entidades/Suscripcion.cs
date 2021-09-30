using System;
using System.Collections.Generic;

namespace CoreGym.Entidades
{
    public class Suscripcion
    {
        public string UniqueId { get;  private set; }

        public string Nombre { get; set; }

        

        public List<Area> Areas { get; set; }

        public List<Clientes> Cliente {get; set;}

        public Suscripcion() => UniqueId = Guid.NewGuid().ToString();
    }
}
