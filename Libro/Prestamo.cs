using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesBiblioteca
{
    public class Prestamo
    {
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public DateTime FechaVencimiento { get; set; }

        public void DatosPrestamo() { }
    }
}
