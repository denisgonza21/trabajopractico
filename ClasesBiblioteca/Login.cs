using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace ClasesBiblioteca
{
    public class Login
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }


        public override string ToString()
        {
            return usuario;
        }


        public static List<Login> listaUsuario = new List<Login>();

        
        public static void EliminarUsuario(Login l)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Login where idLogin = @id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p3 = new SqlParameter("@id", l.id);
                p3.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p3);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarUsuario(int index, Login l)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Login SET Usuario = @usuario, contrasena = @contrasena where idLogin = @id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                //DEFINICION DE PARAMETROS
                SqlParameter p1 = new SqlParameter("@usuario", l.usuario);
                SqlParameter p2 = new SqlParameter("@contrasena", l.contrasena);
                SqlParameter p3 = new SqlParameter("@id", l.id);

                //Le decimos a los parametros de que tipo de datos son
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.Int;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);

                cmd.ExecuteNonQuery();
            }
        }

        public static Login ObtenerUsuarios(int id)
        {
            Login log = null;

            if (listaUsuario.Count == 0)
            {
                Login.ObtenerUsuarioss();
            }

            foreach (Login l in listaUsuario)
            {
                if (l.id == id)
                {
                    log = l;
                    break;
                }
            }

            return log;
        }

        public static List<Login> ObtenerUsuarioss()
        {


            Login log;
            listaUsuario.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCMD = "Select * from Login";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    log = new Login();
                    log.id = elLectorDeDatos.GetInt32(0);
                    log.usuario = elLectorDeDatos.GetString(1);
                    log.contrasena = elLectorDeDatos.GetString(2);

                    listaUsuario.Add(log);
                }

                return listaUsuario;

            }

        }
    }
}
