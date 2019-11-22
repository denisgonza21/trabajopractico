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
        public int id { get; set; }
        public string nombre { get; set; }
        public Editorial editorial { get; set; }
        public Autor autor { get; set; }
        public int cantidad_ejemplares { get; set; }
        public int cantidad_disponible { get; set; }

        public static List<Libro> listaLibros = new List<Libro>();

        public override string ToString()
        {
            return nombre;
        }

        public static void AgregarLibro(Libro l)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open(); //Abrimos la conex con la BD
                string textoCmd = "insert into Libro (nombre, editorial, autor, cantidad_ejemplares, cantidad_disponible) VALUES (@nombre, @editorial, @autor, @ejemplares, @disponibles)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                //PARAMETROS
                SqlParameter p1 = new SqlParameter("@nombre", l.nombre);
                SqlParameter p2 = new SqlParameter("@autor", l.autor.id);
                SqlParameter p3 = new SqlParameter("@editorial", l.editorial.id);
                SqlParameter p4 = new SqlParameter("@ejemplares", l.cantidad_ejemplares);
                SqlParameter p5 = new SqlParameter("@disponibles", l.cantidad_disponible);


                //Le decimos a los parametros de que tipo de datos son
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.Int;
                p3.SqlDbType = SqlDbType.Int;
                p4.SqlDbType = SqlDbType.Int;
                p5.SqlDbType = SqlDbType.Int;


                //Agragamos los parametros al command
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);


                cmd.ExecuteNonQuery();

            }



        }
        public static void EliminarLibro(Libro e)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Libro where Id = @Id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p6 = new SqlParameter("@id", e.id);
                p6.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p6);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarLibro(int index, Libro l)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Libro SET nombre = @nombre, editorial = @editorial, autor = @autor, cantidad_ejemplares = @cantidad_ejemplares, cantidad_disponible = @cantidad_disponible  where id = @id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                //DEFINICION DE PARAMETROS
                SqlParameter p1 = new SqlParameter("@nombre", l.nombre);
                SqlParameter p2 = new SqlParameter("@autor", l.autor.id);
                SqlParameter p3 = new SqlParameter("@editorial", l.editorial.id);
                SqlParameter p4 = new SqlParameter("@cantidad_ejemplares", l.cantidad_ejemplares);
                SqlParameter p5 = new SqlParameter("@cantidad_disponible", l.cantidad_disponible);
                SqlParameter p6 = new SqlParameter("@id", l.id);

                //Le decimos a los parametros de que tipo de datos son
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.Int;
                p3.SqlDbType = SqlDbType.Int;
                p4.SqlDbType = SqlDbType.Int;
                p5.SqlDbType = SqlDbType.Int;
                p6.SqlDbType = SqlDbType.Int;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);

                cmd.ExecuteNonQuery();
            }
        }

        public static Libro ObtenerlLibros(int id)
        {
            Libro libro = null;

            if (listaLibros.Count == 0)
            {
                Libro.ObtenerLibros();
            }

            foreach (Libro e in listaLibros)
            {
                if (e.id == id)
                {
                    libro = e;
                    break;
                }
            }

            return libro;
        }

        public static List<Libro> ObtenerLibros()
        {


            Libro libro;
            listaLibros.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCMD = "Select * from Libro";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    libro = new Libro();
                    libro.id = elLectorDeDatos.GetInt32(0);
                    libro.nombre = elLectorDeDatos.GetString(1);
                    libro.editorial = Editorial.ObtenerEditoriales(elLectorDeDatos.GetInt32(2));
                    libro.autor = Autor.ObtenerAutores(elLectorDeDatos.GetInt32(3));
                    libro.cantidad_ejemplares = elLectorDeDatos.GetInt32(4);
                    libro.cantidad_disponible = elLectorDeDatos.GetInt32(5);

                    listaLibros.Add(libro);
                }

                return listaLibros;

            }

        }
    }
}
        
