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

        public string ObtenerFichaCompleta()
        {
            return $"Nombre:{Nombre} Editorial:{editorial} Autor:{autor} Cant.Ejemplares:{cantidad_ejemplares} Cant.Disponible:{cantidad_disponible}";

        }
    }
}
        
