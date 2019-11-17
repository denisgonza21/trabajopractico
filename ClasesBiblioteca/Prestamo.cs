using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesBiblioteca
{
    public class Prestamo
    {
        public DateTime FechaPrestamo { get; set; }
        public Cliente Cliente { get; set; }
        public Libro Libro { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public DateTime FechaVencimiento { get; set; }

        public static List<Prestamo> listaPrestamos = new List<Prestamo>();


    }
}
