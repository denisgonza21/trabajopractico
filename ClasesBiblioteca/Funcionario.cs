using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ClasesBiblioteca
{
    public class Funcionario
    {
        public int id { get; set; }
        public string nroDocumento { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public DateTime fechaInicio { get; set; }
        public string usuario { get; set; }
        public string constrasena { get; set; }



        public static List<Funcionario> listafuncionario = new List<Funcionario>();

        public static void AgregarFuncionario(Funcionario fun)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCmd = "insert into Funcionario (nroDocumento, nombre, direccion, telefono, fechaInicio, usuario, contrasena) VALUES (@nroDocumento, @nombre, @direccion, @telefono, @fechaInicio, @usuario, @contrasena)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlParameter p1 = new SqlParameter("@nroDocumento", fun.nroDocumento);
                SqlParameter p2 = new SqlParameter("@nombre", fun.nombre);
                SqlParameter p3 = new SqlParameter("@direccion", fun.direccion);
                SqlParameter p4 = new SqlParameter("@telefono", fun.telefono);
                SqlParameter p5 = new SqlParameter("@fechaInicio", fun.fechaInicio);
                SqlParameter p6 = new SqlParameter("@usuario", fun.usuario);
                SqlParameter p7 = new SqlParameter("@contrasena", fun.constrasena);



                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.VarChar;
                p4.SqlDbType = SqlDbType.VarChar;
                p5.SqlDbType = SqlDbType.DateTime;
                p6.SqlDbType = SqlDbType.VarChar;
                p7.SqlDbType = SqlDbType.VarChar;


                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);




                cmd.ExecuteNonQuery();

            }




        }

        public static void EliminarFuncionario(Funcionario fun)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Funcionario where id = @id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p8 = new SqlParameter("@id", fun.id);
                p8.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p8);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarFuncionario(int index, Funcionario fun)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Funcionario SET nroDocumento = @nroDocumento, nombre = @nombre, direccion = @direccion, telefono = @telefono, fechaInicio = @fechaInicio, usuario = @usuario, contrasena = @contrasena  where id = @id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlParameter p1 = new SqlParameter("@nroDocumento", fun.nroDocumento);
                SqlParameter p2 = new SqlParameter("@nombre", fun.nombre);
                SqlParameter p3 = new SqlParameter("@direccion", fun.direccion);
                SqlParameter p4 = new SqlParameter("@telefono", fun.telefono);
                SqlParameter p5 = new SqlParameter("@fechaInicio", fun.fechaInicio);
                SqlParameter p6 = new SqlParameter("@usuario", fun.usuario);
                SqlParameter p7 = new SqlParameter("@contrasena", fun.constrasena);
                SqlParameter p8 = new SqlParameter("@id", fun.id);


                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.VarChar;
                p4.SqlDbType = SqlDbType.VarChar;
                p5.SqlDbType = SqlDbType.DateTime;
                p6.SqlDbType = SqlDbType.VarChar;
                p7.SqlDbType = SqlDbType.VarChar;
                p8.SqlDbType = SqlDbType.Int;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                cmd.Parameters.Add(p8);

                cmd.ExecuteNonQuery();
            }
        }

        public static Funcionario ObtenerFuncionarios(int id)
        {
            Funcionario funcionario = null;

            if (listafuncionario.Count == 0)
            {
                Funcionario.ObtenerFuncionario();
            }

            foreach (Funcionario fun in listafuncionario)
            {
                if (fun.id == id)
                {
                    funcionario = fun;
                    break;
                }
            }

            return funcionario;
        }

        public static List<Funcionario> ObtenerFuncionario()
        {


            Funcionario funcionario;
            listafuncionario.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCMD = "Select * from Funcionario";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    funcionario = new Funcionario();
                    funcionario.id = elLectorDeDatos.GetInt32(0);
                    funcionario.nroDocumento = elLectorDeDatos.GetString(1);
                    funcionario.nombre = elLectorDeDatos.GetString(2);
                    funcionario.direccion = elLectorDeDatos.GetString(3);
                    funcionario.telefono = elLectorDeDatos.GetString(4);
                    funcionario.fechaInicio = elLectorDeDatos.GetDateTime(5);
                    funcionario.usuario = elLectorDeDatos.GetString(6);
                    funcionario.constrasena = elLectorDeDatos.GetString(7);
                    
                 
                    


                    listafuncionario.Add(funcionario);
                }

                return listafuncionario;

            }
        }
        public override string ToString()
        {
            return usuario;
        }
    }
}
