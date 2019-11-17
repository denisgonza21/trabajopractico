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
        public DateTime FechaInscripcion { get; set;}


        public static List<Cliente> listaClientes = new List<Cliente>();
        
        public static List<Cliente> ObtenerClientes()
            
        {
            Cliente cliente;
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "Select * from Cliente";
                SqlCommand cmd = new SqlCommand(textoCMD, con);
                SqlDataReader electorDeDatos = cmd.ExecuteReader();

                while (electorDeDatos.Read())
                {
                    cliente = new Cliente();
                    cliente.id = electorDeDatos.GetInt32(0);
                    cliente.nombre = electorDeDatos.GetString(1);
                    cliente.nroDocumento = electorDeDatos.GetString(2);
                    cliente.direccion = electorDeDatos.GetString(3);
                    cliente.telefono = electorDeDatos.GetString(4);
                    cliente.FechaInscripcion = electorDeDatos.GetDateTime(5);

                    listaClientes.Add(cliente);
                }

            }

                return listaClientes;
        }


    }
}
