using System;
using System.Collections.Generic;

namespace CoreGym.Entidades
{
    public class Area
    {
        public string UniqueId { get; private set; }

        public Area() => UniqueId = Guid.NewGuid().ToString();

        public string Nombre { get; set; }
    }
}
