using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesBiblioteca
{
    public class Libro
    {
        //prueba de repositorio
        public string Nombre { get; set; }
        public Editorial editorial { get; set; }
        public Autor autor { get; set; }
        public int cantidad_ejemplares { get; set; }
        public int cantidad_disponible { get; set; }


        public static List<Libro> listaLibros = new List<Libro>();
        public string ObtenerFichaCompleta()
        {
            return $"Nombre:{Nombre} Editorial:{editorial} Autor:{autor} Cant.Ejemplares:{cantidad_ejemplares} Cant.Disponible:{cantidad_disponible}";

        }

        public static void AgregarLibro(Libro c)
        {
            listaLibros.Add(c);
        }

        public static void EditarLibro(Libro c, int indice)
        {
            Libro.listaLibros[indice] = c;

        }
        public static void EliminarLibro(Libro libro)
        {
            listaLibros.Remove(libro);
        }

        public static List<Libro> ObtenerLibros()
        {
            return listaLibros;
        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
        
