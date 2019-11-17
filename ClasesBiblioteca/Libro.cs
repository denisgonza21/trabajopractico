using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesBiblioteca
{
    public class Libro
    {
        
        public string Nombre { get; set; }
        public Editorial editorial { get; set; }
        public Autor autor { get; set; }
        public int cantidad_ejemplares { get; set; }
        public int cantidad_disponible { get; set; }


        
    }
}
        
