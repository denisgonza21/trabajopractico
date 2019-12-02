using System;
using System.Collections.Generic;
using System.Text;
using ClasesBiblioteca;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace ClasesBiblioteca
{   //clase cliente
    public class Cliente 
    {
        public int id { get; set; }
        public string nroDocumento { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public DateTime fecha_inscripcion { get; set;}


        public static List<Cliente> listaClientes = new List<Cliente>();


        public static void AgregarCliente(Cliente c)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open(); //Abrimos la conex con la BD
                string textoCmd = "insert into Cliente (nroDocumento, nombre, direccion, telefono, fecha_inscripcion) VALUES (@nroDocumento, @nombre, @direccion, @telefono, @fecha_inscripcion)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                //PARAMETROS
                SqlParameter c1 = new SqlParameter("@nroDocumento", c.nroDocumento);
                SqlParameter c2 = new SqlParameter("@nombre", c.nombre);
                SqlParameter c3 = new SqlParameter("@direccion", c.direccion);
                SqlParameter c4 = new SqlParameter("@telefono", c.telefono);
                SqlParameter c5 = new SqlParameter("@fecha_inscripcion", c.fecha_inscripcion);

                //Le decimos a los parametros de que tipo de datos son
                c1.SqlDbType = SqlDbType.VarChar;
                c2.SqlDbType = SqlDbType.VarChar;
                c3.SqlDbType = SqlDbType.VarChar;
                c4.SqlDbType = SqlDbType.VarChar;
                c5.SqlDbType = SqlDbType.DateTime;

                //Agragamos los parametros al command
                cmd.Parameters.Add(c1);
                cmd.Parameters.Add(c2);
                cmd.Parameters.Add(c3);
                cmd.Parameters.Add(c4);
                cmd.Parameters.Add(c5);
                cmd.ExecuteNonQuery();

            }



        }

        public static void EliminarCliente (Cliente c)
        {
            
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from cliente where id = @id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter c6 = new SqlParameter("@id", c.id);
                c6.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(c6);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarCliente (int index, Cliente c)
        {
            //listaProveedores[index] = p;
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Cliente SET nroDocumento = @nroDocumento, nombre= @nombre, direccion = @direccion, telefono = @telefono, fecha_inscripcion = @fecha_inscripcion where id = @id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                //DEFINICION DE PARAMETROS
                SqlParameter c1 = new SqlParameter("@nroDocumento", c.nroDocumento);
                SqlParameter c2 = new SqlParameter("@nombre", c.nombre);
                SqlParameter c3 = new SqlParameter("@direccion", c.direccion);
                SqlParameter c4 = new SqlParameter("@telefono", c.telefono);
                SqlParameter c5 = new SqlParameter("@fecha_inscripcion", c.fecha_inscripcion);
                SqlParameter c6 = new SqlParameter("@id", c.id);

                //Le decimos a los parametros de que tipo de datos son
                c1.SqlDbType = SqlDbType.VarChar;
                c2.SqlDbType = SqlDbType.VarChar;
                c3.SqlDbType = SqlDbType.VarChar;
                c4.SqlDbType = SqlDbType.VarChar;
                c5.SqlDbType = SqlDbType.DateTime;
                c6.SqlDbType = SqlDbType.Int;


                cmd.Parameters.Add(c1);
                cmd.Parameters.Add(c2);
                cmd.Parameters.Add(c3);
                cmd.Parameters.Add(c4);
                cmd.Parameters.Add(c5);
                cmd.Parameters.Add(c6);

                cmd.ExecuteNonQuery();
            }
        }



        public static Cliente ObtenerCliente (int id)
        {
            Cliente cliente = null;

            if (listaClientes.Count == 0)
            {
                Cliente.ObtenerCliente();
            }

            foreach (Cliente c in listaClientes)
            {
                if (c.id == id)
                {
                    cliente = c;
                    break;
                }
            }

            return cliente;
        }





        public static List<Cliente> ObtenerCliente()
            
        {
            Cliente cliente;
            listaClientes.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "Select * from cliente Order by nroDocumento ASC";
                SqlCommand cmd = new SqlCommand(textoCMD, con);
                SqlDataReader electorDeDatos = cmd.ExecuteReader();

                while (electorDeDatos.Read())
                {
                    cliente = new Cliente();
                    cliente.id = electorDeDatos.GetInt32(0);
                    cliente.nombre = electorDeDatos.GetString(2);
                    cliente.nroDocumento = electorDeDatos.GetString(1);
                    cliente.direccion = electorDeDatos.GetString(3);
                    cliente.telefono = electorDeDatos.GetString(4);
                    cliente.fecha_inscripcion = electorDeDatos.GetDateTime(5);

                    listaClientes.Add(cliente);
                }

            }

                return listaClientes;
        }

        public override string ToString()
        {
           
            return nroDocumento;
        }

    }
}
