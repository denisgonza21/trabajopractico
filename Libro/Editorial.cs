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

        public override string ToString()
        {
            return Nombre;
        }

        public static List<Editorial> listaEditoriales = new List<Editorial>();

        public static List<Editorial> ObtenerEditoriales()
        {
            return listaEditoriales;
        }

        public static void AgregarEditorial(Editorial e)
        {
            listaEditoriales.Add(e);
        }

        public static void EliminarEditorial(Editorial e)
        {
            listaEditoriales.Remove(e);
        }

        public static void EditarEditorial(Editorial e, int indice)
        {

            Editorial.listaEditoriales[indice] = e;
        }
    }
}
