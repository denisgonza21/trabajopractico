using System;
using System.Collections.Generic;
using System.Text;
using ClasesBiblioteca;

namespace ClasesBiblioteca
{   //clase cliente
    public class Cliente 
    {
        public int id { get; set; }
        public string nroDocumento { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public DateTime FechaInscripcion { get; set;}

        
    }
}
