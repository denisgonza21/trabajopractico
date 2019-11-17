using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ClasesBiblioteca;

namespace ClasesBiblioteca
{
   public class Editorial
    {
        

        public int id { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }

        public override string ToString()
        {
            return nombre;
        }

        public static List<Editorial> listaEditoriales = new List<Editorial>();

        public static void AgregarEditorial(Editorial e)
        {
            
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open(); //Abrimos la conex con la BD
                string textoCmd = "insert into Editorial (nombre, direccion, telefono) VALUES (@nombre, @direccion, @telefono)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                //PARAMETROS
                SqlParameter p1 = new SqlParameter("@nombre", e.nombre);
                SqlParameter p2 = new SqlParameter("@direccion", e.direccion);
                SqlParameter p3 = new SqlParameter("@telefono", e.telefono);
                

                //Le decimos a los parametros de que tipo de datos son
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.VarChar;
               

                //Agragamos los parametros al command
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
               

                cmd.ExecuteNonQuery();

            }



        }
        public static void EliminarEditorial(Editorial e)
        {
            
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Editorial where Id = @Id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p5 = new SqlParameter("@id", e.id);
                p5.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p5);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarEditorial(int index, Editorial e)
        {
            
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Editorial SET nombre = @nombre, direccion = @direccion, telefono = @telefono,  where id = @id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                //DEFINICION DE PARAMETROS
                SqlParameter p1 = new SqlParameter("@nombre", e.nombre);
                SqlParameter p2 = new SqlParameter("@direccion", e.direccion);
                SqlParameter p3 = new SqlParameter("@telefono", e.telefono);
                SqlParameter p5 = new SqlParameter("@id", e.id);

                //Le decimos a los parametros de que tipo de datos son
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.VarChar;
                p5.SqlDbType = SqlDbType.Int;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p5);

                cmd.ExecuteNonQuery();
            }
        }

        public static Editorial ObtenerEditoriales(int id)
        {
            Editorial editorial = null;

            if (listaEditoriales.Count == 0)
            {
                Editorial.ObtenerEditoriales();
            }

            foreach (Editorial e in listaEditoriales)
            {
                if (e.id == id)
                {
                    editorial = e;
                    break;
                }
            }

            return editorial;
        }

        public static List<Editorial> ObtenerEditoriales()
        {


            Editorial editorial;
            listaEditoriales.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCMD = "Select * from Editorial";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    editorial = new Editorial();
                    editorial.id = elLectorDeDatos.GetInt32(0);
                    editorial.nombre = elLectorDeDatos.GetString(1);
                    editorial.direccion = elLectorDeDatos.GetString(2);
                    editorial.telefono = elLectorDeDatos.GetString(3);

                    listaEditoriales.Add(editorial);
                }

                return listaEditoriales;

            }

        }

        
    }
}
