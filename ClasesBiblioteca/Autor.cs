using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ClasesBiblioteca;

namespace ClasesBiblioteca
{
    

    public class Autor
    {


        public int id { get; set; }
        public string nroDocumento { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        

        public override string ToString()
        {
            return nombre;
        }


        public static List<Autor> listaAutor = new List<Autor>();

        public static void AgregarAutor(Autor a)
        {
            
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open(); //Abrimos la conex con la BD
                string textoCmd = "insert into Autor (nroDocumento, nombre, direccion, telefono) VALUES (@nroDocumento, @nombre, @direccion, @telefono)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                //PARAMETROS
                SqlParameter p1 = new SqlParameter("@nroDocumento", a.nroDocumento);
                SqlParameter p2 = new SqlParameter("@nombre", a.nombre);
                SqlParameter p3 = new SqlParameter("@direccion", a.direccion);
                SqlParameter p4 = new SqlParameter("@telefono", a.telefono);


                //Le decimos a los parametros de que tipo de datos son
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.VarChar;
                p4.SqlDbType = SqlDbType.VarChar;


                //Agragamos los parametros al command
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);


                cmd.ExecuteNonQuery();

            }



        }
        public static void EliminarAutor(Autor a)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Autor where id = @id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p5 = new SqlParameter("@id", a.id);
                p5.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p5);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarAutor(int index, Autor a)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Autor SET nroDocumento = @nroDocumento, nombre = @nombre, direccion = @direccion, telefono = @telefono  where id = @id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                //DEFINICION DE PARAMETROS
                SqlParameter p1 = new SqlParameter("@nroDocumento", a.nroDocumento);
                SqlParameter p2 = new SqlParameter("@nombre", a.nombre);
                SqlParameter p3 = new SqlParameter("@direccion", a.direccion);
                SqlParameter p4 = new SqlParameter("@telefono", a.telefono);
                SqlParameter p5 = new SqlParameter("@id", a.id);

                //Le decimos a los parametros de que tipo de datos son
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.VarChar;
                p4.SqlDbType = SqlDbType.VarChar;
                p5.SqlDbType = SqlDbType.Int;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);

                cmd.ExecuteNonQuery();
            }
        }

        public static Autor ObtenerAutores(int id)
        {
            Autor autor = null;

            if (listaAutor.Count == 0)
            {
                Autor.ObtenerAutores();
            }

            foreach (Autor a in listaAutor)
            {
                if (a.id == id)
                {
                    autor = a;
                    break;
                }
            }

            return autor;
        }

        public static List<Autor> ObtenerAutores()
        {


            Autor autor;
            listaAutor.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCMD = "Select * from Autor";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    autor = new Autor();
                    autor.id = elLectorDeDatos.GetInt32(0);
                    autor.nroDocumento = elLectorDeDatos.GetString(1);
                    autor.nombre = elLectorDeDatos.GetString(2);
                    autor.direccion = elLectorDeDatos.GetString(3);
                    autor.telefono = elLectorDeDatos.GetString(4);

                    listaAutor.Add(autor);
                }

                return listaAutor;

            }

        }
    }
}
