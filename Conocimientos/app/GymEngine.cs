using System;
using System.Collections.Generic;
using System.Linq;
using CoreGym.Entidades;

using static System.Console;

namespace Conocimientos
{
    public class GymEngine
    {
        public Gym Gym { get; set; }

        public GymEngine()
        {
        }

        public void Inicializar()
        {
            Gym = new Gym("FITcontreras");

            CargarSuscripciones();
            CargarAreas();
            CargarCostos();
        }

        private void CargarCostos()
        {
            Random rnd = new Random();
            foreach (var suscripcion in Gym.Suscripciones)
            {
                foreach (var area in suscripcion.Areas)
                {
                    foreach (var cliente in suscripcion.Cliente)
                    {
                        var rmd = new Random(System.Environment.TickCount);

                        for (int i = 0; i < 5; i++)
                        {
                            var ev =
                                new Costos {
                                    Area = area,
                                    Nombre = $"{area.Nombre} Ev#{i + 1}",
                                    Cliente = cliente,
                                    Precio = (int)(rmd.Next(50, 350))
                                };

                            cliente.Costos.Add (ev);

                            var turno = suscripcion.Nombre;

                            if (turno == "Mañana")
                            {
                                ev.Precio = (int)(rmd.Next(50, 100));
                            }
                            else if (turno == "Tarde")
                            {
                                ev.Precio = (int)(rmd.Next(101, 200));
                            }
                            else if (turno == "Noche")
                            {
                                ev.Precio = (int)(rmd.Next(201, 350));
                            }
                            System
                                .Console
                                .WriteLine($@"Nombre cliente: {
                                    cliente.Nombre} Area: {
                                    area.Nombre} Costo: $$ {ev.Precio}, Turno: {
                                    suscripcion.Nombre}");
                        }
                    }
                }
            }
        }

        private void CargarAreas()
        {
            foreach (var Suscipcion in Gym.Suscripciones)
            {
                List<Area> listaAreas =
                    new List<Area> {
                        new Area { Nombre = "Pesas" },
                        new Area { Nombre = "Cardio" },
                        new Area { Nombre = "Pierna" },
                        new Area { Nombre = "Bicicleta" }
                    };

                Suscipcion.Areas = listaAreas;
            }
        }

        // Cargar Clientes
        private List<Clientes> GenerarClientesAlAzar(int cantidad)
        {
            string[] nombre1 =
            {
                "Alba",
                "Felipa",
                "Eusebio",
                "Farid",
                "Donald",
                "Alvaro",
                "Nicolás"
            };
            string[] apellido1 =
            {
                "Ruiz",
                "Sarmiento",
                "Uribe",
                "Maduro",
                "Trump",
                "Toledo",
                "Herrera"
            };
            string[] nombre2 =
            {
                "Freddy",
                "Anabel",
                "Rick",
                "Murty",
                "Silvana",
                "Diomedes",
                "Nicomedes",
                "Teodoro"
            };

            // Recorremos cada miembro de la lista y por cada n1, n2 y a1 de genera un nombre
            var listaClientes =
                from n1 in nombre1
                from n2 in nombre2
                from a1 in apellido1
                select new Clientes { Nombre = $"{n1} {n2} {a1}" };

            // se retorna una lista de alimnos de acurdo con su ID y una cantidad especifica
            return listaClientes
                .OrderBy((al) => al.UniqueId)
                .Take(cantidad)
                .ToList();
        }

        private void CargarSuscripciones()
        {
            Gym.Suscripciones =
                new List<Suscripcion>()
                {
                    new Suscripcion() { Nombre = "Mañana" },
                    new Suscripcion() { Nombre = "Tarde" },
                    new Suscripcion() { Nombre = "Noche" }
                };

            Random rnd = new Random();

            foreach (var c in Gym.Suscripciones)
            {
                int cantidadRandom = rnd.Next(3);
                c.Cliente = GenerarClientesAlAzar(cantidadRandom);
            }
        }
    }
}
