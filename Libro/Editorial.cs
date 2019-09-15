using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesBiblioteca
{
   public class Editorial
    {
        // clase Editorial

        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public string ObtenerDatosEditorial()
        {
            return $"Nombre:{Nombre} Telefono:{Telefono} Direccion:{Direccion}";
        }
    }
}
