using System;
using System.Collections.Generic;
using System.Text;
using ClasesBiblioteca;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace ClasesBiblioteca
{
    public class Libro
    {
        
        public string Nombre { get; set; }
        public Editorial editorial { get; set; }
        public Autor autor { get; set; }
        public int cantidad_ejemplares { get; set; }
        public int cantidad_disponible { get; set; }

        public static List<Libro> listaLibros = new List<Libro>();



        public static List<Libro> ObtenerLibros()

        {
            Libro libro;
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "Selecte * from Libro";
                SqlCommand cmd = new SqlCommand(textoCMD, con);
                SqlDataReader electorDeDatos = cmd.ExecuteReader();

                while (electorDeDatos.Read())
                {
                    libro = new Libro();
                    libro.Nombre = electorDeDatos.GetString(0);
                    libro.autor = Autor.ObtenerAutores(electorDeDatos.GetInt32(1));
                    libro.editorial = Editorial.ObtenerEditoriales(electorDeDatos.GetInt32(2));
                    libro.cantidad_disponible = electorDeDatos.GetInt32(3);
                    libro.cantidad_ejemplares = electorDeDatos.GetInt32(4);
                    

                    listaLibros.Add(libro);
                }

            }

            return listaLibros;
        }


    }
}
        
