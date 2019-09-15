using System;

namespace ClasesBiblioteca
{
    public class Libro
    {
        public string Nombre { get; set; }
        public string Editorial { get; set; }
        public string Autor { get; set; }
        public int cantidad_ejemplares { get; set; }
        public int cantidad_disponible { get; set; }

        public Libro() { }

        public string ObtenerFichaCompleta()
        {
            return $"Nombre:{Nombre} Editorial:{Editorial} Autor:{Autor} Cant.Ejemplares:{cantidad_ejemplares} Cant.Disponible:{cantidad_disponible}";
        }
    }
}
