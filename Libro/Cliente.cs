using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesBiblioteca
{
    class Cliente : Persona
    {
        public string Direccion { get; set; }
        public DateTime FechaInscripcion { get; set;}

        public Cliente() { }

    }
}
