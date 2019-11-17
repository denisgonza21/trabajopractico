using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBiblioteca
{
    public class PrestamoDetalle
    {
        public double cantidad { get; set; }
        public Libro libro { get; set; }
        public DateTime fecha_devolucion { get; set; }

    }
}
