using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClasesBiblioteca
{
    public class Conexion
    {



        public void autoCompletar(ComboBox cajaTexto)
        {
            SqlDataReader dr;
            try
            {

                using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

                {
                    
                    con.Open(); //Abrimos la conex con la BD
                    string textoCmd = "Select nroDocumento from Cliente)";
                    SqlCommand cmd = new SqlCommand(textoCmd, con);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cajaTexto.AutoCompleteCustomSource.Add(dr["nroDocumento"].ToString());
                    }
                    dr.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo autocompletar el TextBox: " + ex.ToString());
            }
        }
    }
}
