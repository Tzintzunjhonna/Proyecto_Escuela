/*Espacio de nombres*/
using System.Collections.Generic;
using System;
using CoreEscuela.Entidades;

namespace CoreEscuela.Entidades
{
    public class Escuela: ObjetoEscuelaBase
    {
        string nombre;

        public int AñoDeCreacion { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public TiposEscuela TiposEscuela { get; set; }

        /* Atributo de cursos array */

        // Colocar arreglo para una lista de cursos 
        //con su espacio de nombres using System.Collections.Generic;
        public List<Curso> Cursos { get; set; }

        /*Constructor*/

        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);
        
        public Escuela(string nombre, int año, 
        TiposEscuela tipo, 
        string pais="", string ciudad="") {
            (Nombre, AñoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString(){
            return $"Nombre: \"{Nombre}\", Tipo: {TiposEscuela} {System.Environment.NewLine} Pais: {Pais}, Ciudad:{Ciudad}";        }
    }
}
