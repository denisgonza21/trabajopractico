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

        public static List<Prestamo> listaPrestamos = new List<Prestamo>();


        public static void AgreagarPrestamo(Prestamo prestamo)
        {
            listaPrestamos.Add(prestamo);
        }

        public static void EliminarPrestamo(Prestamo prestamo)
        {
            listaPrestamos.Remove(prestamo);
        }

        public static List<Prestamo> ObtenerPrestamos()
        {
            return listaPrestamos;
        }

        public static void EditarPrestamo(Prestamo prestamo, int indice)
        {

            Prestamo.listaPrestamos[indice] = prestamo;
        }


        public void DatosPrestamo() { }
    }
}
