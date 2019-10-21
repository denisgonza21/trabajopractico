using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesBiblioteca
{
    public enum GeneroLiterario
    {
        Novelas,
        CienciaFiccion,
        Fantastica,
        Drama
    }

    public class Autor:Persona
    {
        

        public GeneroLiterario Genero { get; set; }

        public override string ToString()
        {
            return NombreApellido;
        }


        public static List<Autor> listaAutor = new List<Autor>();

        public static List<Autor> ObtenerAutores()
        {
            return listaAutor;
        }

        public static void AgregarAutor(Autor a)
        {
            listaAutor.Add(a);
        }

        public static void EliminarAutor(Autor a)
        {
            listaAutor.Remove(a);
        }

        public static void EditarAutor(Autor a, int indice)
        {

            Autor.listaAutor[indice] = a;
        }
    }
}
