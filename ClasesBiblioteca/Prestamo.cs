using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ClasesBiblioteca;


namespace ClasesBiblioteca
{
    public class Prestamo
    {
        public int id { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public Cliente Cliente { get; set; }
        public Libro Libro { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public DateTime FechaVencimiento { get; set; }


        public override string ToString()
        {
            return this.Cliente.nombre;
        }

        public static List<Prestamo> listaPrestamos = new List<Prestamo>();

        public List<PrestamoDetalle> detalle_prestamo = new List<PrestamoDetalle>();


        public static void AgregarPrestamo(Prestamo p)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {

                con.Open();//Abrimos la conex con la BD
                string textoCmd = "insert into Prestamo (nombre, direccion, telefono) VALUES (@nombre, @direccion, @telefono)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter p1 = new SqlParameter("@FechaPrestamo", p.FechaPrestamo);
                SqlParameter p2 = new SqlParameter("@FechaDevolucion",p.FechaDevolucion);
                SqlParameter p3 = new SqlParameter("@FechaVencimiento", p.FechaVencimiento);


                p1.SqlDbType = System.Data.SqlDbType.DateTime;
                p2.SqlDbType = System.Data.SqlDbType.DateTime;
                p3.SqlDbType = System.Data.SqlDbType.DateTime;
              
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
               


                
                int id_prestamo = (int)cmd.ExecuteScalar();

                //Detalle
                foreach (PrestamoDetalle dp in p.detalle_prestamo)
                {
                    // insert para el detalle
                    String textoCMD2 = "INSERT INTO Prestamo_Detalle(prestamo_id,cantidad,libro)VALUES(@prestamo_id,@cantidad,@libro)";
                    SqlCommand cmd2 = new SqlCommand(textoCMD2, con);

                    SqlParameter p6 = new SqlParameter("@id", id_prestamo);
                    SqlParameter p7 = new SqlParameter("@cantidad", dp.cantidad);
                    SqlParameter p8 = new SqlParameter("@libro", dp.libro.autor);

                    cmd2.Parameters.Add(p6);
                    cmd2.Parameters.Add(p7);
                    cmd2.Parameters.Add(p8);

                    cmd2.ExecuteNonQuery();

                }
            }
        }


        public static void Eliminar(Prestamo p)
        {
            listaPrestamos.Remove(p);
        }

        public static List<Prestamo> Obtener()
        {
            return listaPrestamos;
        }



        public static void EditarPrestamo(int index, Prestamo e)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Prestamo SET FechaPrestamo = @FechaPrestamo, FechaDevolucion = @FechaDevolucion, FechaVencimiento = @FechaVencimiento,  where id = @id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                //DEFINICION DE PARAMETROS
                SqlParameter p1 = new SqlParameter("@FechaPrestamo", e.FechaPrestamo);
                SqlParameter p2 = new SqlParameter("@FechaDevolucion", e.FechaDevolucion);
                SqlParameter p3 = new SqlParameter("@FechaVencimiento", e.FechaVencimiento);
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


    }
}
