using System;
using System.Collections.Generic;
using CoreGym.Entidades;

using static System.Console;

namespace Conocimientos
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new GymEngine();
            engine.Inicializar();

            ImprimirSuscripcionGym(engine.Gym);
        }

        private static void ImprimirSuscripcionGym(Gym gym)
        {
            if (gym?.Suscripciones != null)
            {
                foreach (var suscripcion in gym.Suscripciones)
                {
                    Console
                        .WriteLine($@"Tipos de suscripcion: {
                            suscripcion.Nombre} Id: {suscripcion.UniqueId}");
                }
            }
        }
    }
}
