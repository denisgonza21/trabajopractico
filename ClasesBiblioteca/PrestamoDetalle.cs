using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBiblioteca
{

    public enum Estado
    {
        Entregado,
        No_Entregado
    }

    public class PrestamoDetalle
    {
        public int id;
        public double cantidad { get; set; }
        public Libro libro { get; set; }
        public DateTime fecha_vencimiento { get; set; }

        public Estado estado { get; set; }



        public static void EditarDetalle(int index)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                DateTime fecha = DateTime.Now;
                int n = 0;
                string textoCMD = "update Prestamo_Detalle set estado = '"+n+"', fecha_devolucion = '"+fecha+"' where id = "+index;

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                //DEFINICION DE PARAMETROS
                SqlParameter p1 = new SqlParameter("@estado", n);
                SqlParameter p2 = new SqlParameter("@fecha_devolucion", fecha);
             

                //Le decimos a los parametros de que tipo de datos son
                p1.SqlDbType = SqlDbType.Int;
                p2.SqlDbType = SqlDbType.DateTime;
               

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
               

                cmd.ExecuteNonQuery();
            }
        }
    }

}
