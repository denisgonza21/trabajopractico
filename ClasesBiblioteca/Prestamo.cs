﻿using System;
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
        public DateTime fecha_prestamo { get; set; }
        public Cliente cliente { get; set; }

        public override string ToString()
        {
            return this.cliente.nombre;
        }

        public static List<Prestamo> listaPrestamos = new List<Prestamo>();
        public static List<Prestamo> listaPrestamos2 = new List<Prestamo>();

        public List<PrestamoDetalle> detalle_prestamo = new List<PrestamoDetalle>();


        public static void AgregarPrestamo(Prestamo p)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {

                con.Open();//Abrimos la conex con la BD
                string textoCmd = "INSERT INTO Prestamo (cliente, fechaprestamo)  output INSERTED.id VALUES (@cliente, @fecha_prestamo)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter p1 = new SqlParameter("@cliente", p.cliente.id);
                SqlParameter p2 = new SqlParameter("@fecha_prestamo", p.fecha_prestamo);


                p1.SqlDbType = System.Data.SqlDbType.Int;
                p2.SqlDbType = System.Data.SqlDbType.DateTime;
               
              
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                

                int id_prestamo = (int)cmd.ExecuteScalar();

                //Detalle
                foreach (PrestamoDetalle dp in p.detalle_prestamo)
                {
                    // insert para el detalle
                    String textoCMD2 = "INSERT INTO Prestamo_Detalle(prestamo_id, cantidad, libro, estado, fecha_vencimiento )VALUES(@id, @cantidad, @libro, @estado, @fecha_vencimiento)";
                    SqlCommand cmd2 = new SqlCommand(textoCMD2, con);

                    SqlParameter p6 = new SqlParameter("@id", id_prestamo);
                    SqlParameter p7 = new SqlParameter("@cantidad", dp.cantidad);
                    SqlParameter p8 = new SqlParameter("@libro", dp.libro.id);
                    SqlParameter p15 = new SqlParameter("@estado", dp.estado);
                    SqlParameter p16 = new SqlParameter("@fecha_vencimiento", dp.fecha_vencimiento);

                    //SqlParameter p9 = new SqlParameter("@fecha_devolucion", dp.fecha_devolucion);

                    cmd2.Parameters.Add(p6);
                    cmd2.Parameters.Add(p7);
                    cmd2.Parameters.Add(p8);
                    cmd2.Parameters.Add(p15);
                    cmd2.Parameters.Add(p16);
                    // cmd2.Parameters.Add(p9);

                    cmd2.ExecuteNonQuery();

                }
            }
        }


        public static void Eliminar(Prestamo p)
        {
            listaPrestamos.Remove(p);
        }

        public static Prestamo ObtenerPrestamos(int id)
        {
            Prestamo prestamo = null;

            if (listaPrestamos.Count == 0)
            {
                Prestamo.ObtenerPrestamos();
            }

            foreach (Prestamo e in listaPrestamos)
            {
                if (e.id == id)
                {
                    prestamo = e;
                    break;
                }
            }

            return prestamo;
        }

        public static List<Prestamo> ObtenerPrestamos()
        {


            Prestamo prestamo;
            listaPrestamos.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCMD = "Select * from Prestamo where id=@id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    prestamo = new Prestamo();
                    prestamo.id = elLectorDeDatos.GetInt32(0);
                    prestamo.cliente.id = elLectorDeDatos.GetInt32(1);
                    

                    listaPrestamos.Add(prestamo);
                }

                return listaPrestamos;

            }

        }

    }
}
